import { useState } from "react";

import { Announcment } from "../components/Announcment";
import { AdjustableModal } from "../components/AdjustableModal";
import { Input } from "../components/Input";
import { PrimaryButton } from "../components/PrimaryButton";
import { ErrorMenssage } from "../components/ErrorMenssage";

import { Link } from "react-router-dom";

import logoImg from "../assets/logo.svg";

export function Login() {
  const [cpf, setCpf] = useState()
  const [password, setPassword] = useState()

  function handleLogin() {
    console.log(cpf, password)
  }

  return (
    <div className="w-full h-screen justify-between flex flex-col md:flex-row md:justify-normal">
      <Announcment />

      <div className="self-center md:w-2/4 xl:w-3/5">
        <img className="w-40 mx-auto" src={logoImg} alt="logo time sheet" />
      </div>

      <div className="md:w-2/4 md:mr-auto xl:w-2/5">
        <AdjustableModal>
          <div className="p-10 md:mt-44 2xl:w-3/5 2xl:self-center">
            <div>
              <h1 className="text-3xl font-bold text-time-sheet mb-2 select-none">
                Bem vindo!
              </h1>
              <p className="text-sm font-semibold text-time-sheet mb-5 select-none">
                Trabalho com mais controle e segurança.
              </p>
            </div>

            <Input 
              title="CPF" type="text" 
              mask="999.999.999-99"
              value={cpf}
              onChange={e => setCpf(e.target.value)}  
            />
            <Input 
              title="Senha" 
              type="password"
              value={password}
              onChange={e => setPassword(e.target.value)}
            />
            {/* <ErrorMenssage errorMenssage="CPF ou senha inválidos"/> */}

            <a href="#" className="text-base text-slate-600">
              Esqueceu a senha?
              <span className="text-base text-primary-200"> Alterar</span>
            </a>

            <Link to="/">
              <PrimaryButton title="Entrar" bgColor="primary-800" onClick={handleLogin}/>
            </Link>
          </div>
        </AdjustableModal>
      </div>
    </div>
  );
}
