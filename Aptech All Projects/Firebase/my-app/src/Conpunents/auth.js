import React, { useState } from 'react'
import { createUserWithEmailAndPassword, signInWithPopup, signOut } from 'firebase/auth';
import { auth, googleProvider } from '../Config/firebase'

const Auth = () => {

    const [email, setEmail] = useState("");
    const [password, setPassword] = useState("");
    console.log(auth?.currentUser?.email);

    const SignIn = async () => {
        try {
            await createUserWithEmailAndPassword(auth, email, password);
            if (auth) {
                alert("loged in")
            }
        } catch (error) {
            alert(error)
        }
    }

    const logout = async () => {
        try {
            await signOut(auth);
            if (auth?.currentUser?.email) {
                alert("Signed Out")
            }
        } catch (error) {
            alert(error.message)
        }
    }

    const loginWithGoogle = async () => {
        try {
            await signInWithPopup(auth, googleProvider);
        } catch (error) {
            alert(error.message)
        }
    }

    return (
        <React.Fragment>

            <h1>
                {auth?.currentUser?.email}
            </h1>

            <div>
                <h1>
                    With Local Email
                </h1>
                <input placeholder='Email' onChange={(e) => setEmail(e.target.value)} type='email' />
                <input placeholder='Password' onChange={(e) => setPassword(e.target.value)} type='password' />
                <button onClick={SignIn}> SignIn </button>
                <button onClick={logout}> Logout</button>
            </div>

            <div>
                <h1>
                    With Google Email
                </h1>
                <button onClick={loginWithGoogle}> Login With Google</button>
            </div>
        </React.Fragment>
    )
}

export default Auth
