import React from "react";
import { Text, View, Image, Pressable } from "react-native";
import { useRoute } from "@react-navigation/native";
import { Checkbox } from "react-native-paper";
import Header from "../components/Header";
import AdjustableModal from "../components/AdjustableModal";
import Input from "../components/Input";
import Button from "../components/Button";
import ErrorMessage from "../components/ErrorMessage";
import Icon from "react-native-vector-icons/MaterialCommunityIcons";
import CustomModal from "../components/CustomModal";
import Divider from "../components/Divider";
import { parseToTimeValue } from "../common/utils";
import {
  nameValidations,
  cpfValidations,
  timeValidations,
} from "../common/validations";
import { useInput } from "../hooks/useInput";
import { AlertModalContent, InfoModalContent } from "../components/ModalContents";
import * as UserService from "../services/UserService";
import AuthContext from "../contexts/AuthContext";

const logo = require("../../assets/logo.png");

export default function EditUserPage({ navigation }) {
  const route = useRoute();
  const { item, updateUsers } = route.params;
  const [modalVisible, setModalVisible] = React.useState(false);
  const [modalContent, setModalContent] = React.useState(null);
  const [role, setRole] = React.useState(item.role === "Administrator");
  const [waitingResponse, setWaitingResponse] = React.useState(false);

  var lunchTime = parseToTimeValue(item.lunchTime);
  var totalTime = parseToTimeValue(item.workTime);

  const { userData } = React.useContext(AuthContext);
  const [myId, setMyId] = React.useState(userData.id)

  /* Name Input */

  const nameInput = useInput(item.name);
  nameInput.setValidation(
    nameValidations.nameIsBlank,
    "O Nome não pode estar em branco."
  );
  nameInput.setValidation(
    nameValidations.nameLengthTooShort,
    "O Nome precisa ter no mínimo 3 caracteres."
  );
  nameInput.setValidation(
    nameValidations.nameLengthTooLong,
    "O Nome pode ter no máximo 50 caracteres."
  );

  /* CPF input */

  const cpfInput = useInput(item.cpf);
  cpfInput.setValidation(
    cpfValidations.cpfIsBlank,
    "O CPF não pode estar em branco."
  );
  cpfInput.setValidation(
    cpfValidations.cpfLengthTooShort,
    "O CPF precisa ter 11 dígitos."
  );
  cpfInput.setValidation(
    cpfValidations.cpfIsAllDigitsSame,
    "O CPF não pode ter todos os dígitos iguais."
  );
  cpfInput.setValidation(
    cpfValidations.cpfIsInvalid,
    "O CPF informado não é válido."
  );

  /* TotalTime Input */

  const totalTimeInput = useInput(item.workTime);
  totalTimeInput.setValidation(
    timeValidations.timeIsBlank,
    "O tempo total de trabalho não pode estar em branco."
  );
  totalTimeInput.setValidation(
    timeValidations.timeIsOutsideTimeBounds,
    "O tempo total de trabalho precisa estar dentro do limite de 0h às 24h."
  );

  /* LunchTime Input */

  const lunchTimeInput = useInput(item.lunchTime);
  lunchTimeInput.setValidation(
    timeValidations.timeIsBlank,
    "O tempo de almoço não pode estar em branco."
  );
  lunchTimeInput.setValidation(
    timeValidations.timeIsOutsideTimeBounds,
    "O tempo de almoço precisa estar dentro do limite de 0h às 24h."
  );
  lunchTimeInput.setValidation(
    (lunchTime) => lunchTime > totalTimeInput.value ?? 0,
    "O tempo de almoço não pode ser maior que o tempo de trabalho."
  );

  function goBack() {
    updateUsers();
    navigation.goBack();
  }

  function hideModal() {
    updateModalContent();
    setModalVisible(false);
  }

  function updateUser() {
    cpfInput.validate(cpfInput.value);
    nameInput.validate(nameInput.value);
    totalTimeInput.validate(totalTimeInput.value);
    lunchTimeInput.validate(lunchTimeInput.value);

    var cpf = cpfInput.value;
    var name = nameInput.value;
    var totalTime = totalTimeInput.value;
    var lunchTime = lunchTimeInput.value;

    if (!cpf || !name || !totalTime || !lunchTime) {
      return;
    }

    setWaitingResponse(true);

    UserService.UpdateUser(
      item.id,
      nameInput.value,
      cpfInput.value,
      totalTimeInput.value,
      lunchTimeInput.value,
      role ? 0 : 1
    ).then((result) => {

      switch (result.status) {
        case "UserUpdated":
          setModalContent(
            <InfoModalContent
              title="Funcionário atualizado"
              message="As informações do funcionário foram atualizadas."
              goBack={goBack} />
          );
          break;
        case "UserAlreadyExists":
          setModalContent(
            <AlertModalContent
              title="CPF já cadastrado"
              message="Já existe um funcionário com esse CPF cadastrado."
              goBack={() => setModalVisible(false)} />
          );
          break;
        case "InvalidUserData":
          setModalContent(
            <AlertModalContent
              title="Informações inválidas"
              message="Verifique as informações preenchidas e tente novamente."
              goBack={() => setModalVisible(false)} />
          );
          break;
        default:
          setModalContent(
            <AlertModalContent
              title="Erro ao se comunicar com o servidor"
              message="Verifique sua conexão com a internet e tente novamente."
              goBack={goBack} />
          );
          break;
      }

      setModalVisible(true);
      setWaitingResponse(false);
    });
  }

  function disableUser() {
    setWaitingResponse(true);
    if (item.id !== myId) {
      UserService.disableUser(item.id).then((result) => {

        switch (result.status) {
          case "UserDisabled":
            updateModalContent("confirm-user-disabled");
            break;
          case "MasterUserCannotBeDisabled":
            updateModalContent("master-user-cannot-be-disabled");
            break;
          case "CurrentUser":
            updateModalContent("current-user-cannot-be-disabled");
            break;
          default:
            updateModalContent("error");
            break;
        }
      });

    } else {
      updateModalContent("current-user-cannot-be-disabled");
    }

    setWaitingResponse(false);
  }

  function deleteUser() {
    setWaitingResponse(true);
    if (item.id !== myId) {
      UserService.deleteUser(item.id).then((result) => {

        switch (result.status) {
          case "UserDeleted":
            updateModalContent("confirm-user-deleted");
            break;
          case "MasterUserCannotBeDeleted":
            updateModalContent("master-user-cannot-be-deleted");
            break;
          case "UserNotDeleted":
            updateModalContent("current-user-cannot-be-deleted");
            break;
          default:
            updateModalContent("error");
            break;
        }
      });
    } else {
      updateModalContent("current-user-cannot-be-deleted");
    }

    setWaitingResponse(false);
  }

  function changeUserPassword() {
    setModalVisible(false);
    navigation.navigate("EditUserPasswordPage", { item, updateUsers });
  }

  function updateModalContent(content) {
    switch (content) {
      case "disable-user":
        setModalContent(
          <DisableUserModalContent
            disableAction={disableUser}
            backAction={updateModalContent}
            waitingResponse={waitingResponse}
          />
        );
        break;
      case "current-user-cannot-be-disabled":
        setModalContent(
          <AlertModalContent
            title="Funcionário atualmente logado"
            message="Faça login com outro usuário para se desabilitar do aplicativo."
            goBack={hideModal} />
        );
        break;
      case "master-user-cannot-be-disabled":
        setModalContent(
          <AlertModalContent
            title="Funcionário administrador"
            message="Não é possível desabilitar esse funcionário do aplicativo."
            goBack={hideModal} />
        );
        break;
      case "confirm-user-disabled":
        setModalContent(
          <InfoModalContent
            title="Funcionário desabilitado"
            message="Volte para a lista de funcionários para reabilita-lo."
            goBack={goBack} />
        );
        break;
      case "confirm-user-deleted":
        setModalContent(
          <InfoModalContent
            title="Funcionário excluído"
            message="Funcionário excluído permanentemente da plataforma."
            goBack={goBack} />
        );
        break;
      case "delete-user":
        setModalContent(
          <DeleteUserModalContent
            deleteAction={deleteUser}
            backAction={updateModalContent}
          />
        );
        break;
      case "current-user-cannot-be-deleted":
        setModalContent(
          <AlertModalContent
            title="Funcionário atualmente logado"
            message="Faça login com outro usuário para se excluir do aplicativo."
            goBack={hideModal} />
        );
        break;
      case "master-user-cannot-be-deleted":
        setModalContent(
          <AlertModalContent
            title="Funcionário administrador"
            message="Não é possível excluir esse funcionário do aplicativo."
            goBack={hideModal} />
        );
        break;
      case "error":
        setModalContent(
          <AlertModalContent
            title="Erro ao se comunicar com o servidor"
            message="Verifique sua conexão com a internet e tente novamente."
            goBack={goBack} />
        );
        break;
      default:
        setModalContent(
          <OptionsModalContent
            changePasswordAction={changeUserPassword}
            disableAction={() => updateModalContent("disable-user")}
            deleteAction={() => updateModalContent("delete-user")}
            backAction={hideModal}
          ></OptionsModalContent>
        );
        break;
    }
  }

  React.useEffect(() => {
    updateModalContent();
  }, []);

  return (
    <View className="flex-1 w-full bg-primary-600">
      <CustomModal visible={modalVisible}>{modalContent}</CustomModal>

      <Header />
      <View className="flex w-full justify-center items-center mt-20 py-10">
        <Image
          className="object-contain object-center h-36 w-36"
          source={logo}
        />
      </View>
      <View className="flex-1 w-full flex-col justify-end items-center mt-20">
        <AdjustableModal keyboardVerticalOffset={-200}>
          <View className="flex h-full w-full">
            <View className="flex flex-row justify-between align-center">
              <View>
                <Text className="text-3xl font-bold text-primary-800 mb-1">
                  {item.name}
                </Text>
                <Text className="text-sm font-semibold mb-5">
                  Alterar dados do funcionário
                </Text>
              </View>
              <Pressable onPress={() => setModalVisible(!modalVisible)}>
                <Icon name="cog" size={36} color="#1E3F42" />
              </Pressable>
            </View>
            <Input
              className="mb-2"
              value={nameInput.value}
              label="Nome"
              placeholder="digite o nome completo"
              setInputValue={nameInput.validate}
            />
            <ErrorMessage
              show={nameInput.errorVisible}
              message={nameInput.errorMessage}
            />
            <Input
              value={cpfInput.value}
              className="mb-2"
              label="CPF"
              placeholder="000.000.000-00"
              keyboardType="numeric"
              mask="999.999.999-99"
              setInputValue={cpfInput.validate}
            />
            <ErrorMessage
              show={cpfInput.errorVisible}
              message={cpfInput.errorMessage}
            />
            <Input
              value={totalTime}
              className="mb-2"
              label="Jornada de trabalho"
              placeholder="00:00"
              keyboardType="numeric"
              mask="99:99"
              setInputValue={(value) =>
                totalTimeInput.validate(parseFloat(value.replace(":", ".")))
              }
            />
            <ErrorMessage
              show={totalTimeInput.errorVisible}
              message={totalTimeInput.errorMessage}
            />
            <Input
              className="mb-2"
              value={lunchTime}
              label="Tempo de almoço"
              placeholder="00:00"
              keyboardType="numeric"
              mask="99:99"
              setInputValue={(value) =>
                lunchTimeInput.validate(parseFloat(value.replace(":", ".")))
              }
            />
            <ErrorMessage
              show={lunchTimeInput.errorVisible}
              message={lunchTimeInput.errorMessage}
            />
            <View className="flex flex-row items-center mb-2">
              <Checkbox
                color="#1E3F42"
                status={role ? "checked" : "unchecked"}
                onPress={() => {
                  setRole(!role);
                }}
              />
              <Text className="text-sm font-bold">
                Funcionário Administrador?
              </Text>
            </View>
            <Button
              title="Salvar alterações"
              color="primary-600"
              disabled={waitingResponse}
              isRunning={waitingResponse}
              onPress={updateUser}
            />
            <Button
              className="mt-5"
              disabled={waitingResponse}
              title="Voltar"
              color="primary-600"
              type="outline"
              onPress={() => {
                navigation.goBack();
              }}
            />
          </View>
        </AdjustableModal>
      </View>
    </View>
  );
}

function OptionsModalContent({
  changePasswordAction,
  disableAction,
  deleteAction,
  backAction,
}) {
  return (
    <View>
      <Button
        className="mb-5"
        title="Alterar senha de acesso"
        color="primary-400"
        icon={
          <Icon
            name="lock-reset"
            color="white"
            size={24}
            style={{ marginRight: 6 }}
          />
        }
        onPress={changePasswordAction}
      />
      <Button
        style={{ backgroundColor: "#475569" }}
        className="mb-5"
        title="Desabilitar funcionário"
        color="slate-700"
        icon={
          <Icon
            name="account-cancel-outline"
            color="white"
            size={24}
            style={{ marginRight: 6 }}
          />
        }
        onPress={disableAction}
      />
      <Button
        style={{ backgroundColor: "#dc2626" }}
        className="mb-5"
        title="Excluir funcionário"
        icon={
          <Icon
            name="delete-forever"
            color="white"
            size={24}
            style={{ marginRight: 6 }}
          />
        }
        onPress={deleteAction}
      />
      <Divider />
      <Button
        className="mt-5"
        title="Voltar"
        type="outline"
        color="primary-400"
        onPress={backAction}
      />
    </View>
  );
}

function DisableUserModalContent({
  disableAction,
  backAction,
  waitingResponse,
}) {
  return (
    <View>
      <Text className="text-3xl font-bold text-primary-800 mb-1">
        Desabilitar funcionário?
      </Text>
      <Text className="text-sm font-semibold mb-5">
        Desabilitar um funcionário impede que ele acesse a plataforma.
      </Text>
      <Button
        style={{ backgroundColor: "#475569" }}
        disabled={waitingResponse}
        isRunning={waitingResponse}
        className="mb-5"
        title="Desabilitar funcionário"
        color="slate-700"
        icon={
          <Icon
            name="account-cancel-outline"
            color="white"
            size={24}
            style={{ marginRight: 6 }}
          />
        }
        onPress={disableAction}
      />
      <Divider />
      <Button
        className="mt-5"
        disabled={waitingResponse}
        title="Voltar"
        type="outline"
        color="primary-400"
        onPress={backAction}
      />
    </View>
  );
}

function DeleteUserModalContent({ deleteAction, backAction }) {
  return (
    <View>
      <Text className="text-3xl font-bold text-danger-600 mb-1">
        Excluir funcionário?
      </Text>
      <Text className="text-sm font-semibold mb-5">
        Essa ação exclui o usuário do aplicativo e é irreversível.
      </Text>
      <Button
        style={{ backgroundColor: "#dc2626" }}
        className="mb-5"
        title="Excluir funcionário"
        icon={
          <Icon
            name="delete-forever"
            color="white"
            size={24}
            style={{ marginRight: 6 }}
          />
        }
        onPress={deleteAction}
      />
      <Divider />
      <Button
        className="mt-5"
        title="Voltar"
        type="outline"
        color="primary-400"
        onPress={backAction}
      />
    </View>
  );
}
