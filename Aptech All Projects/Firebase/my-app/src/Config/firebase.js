import { initializeApp } from "firebase/app";
import { getAuth ,GoogleAuthProvider} from "firebase/auth";

const firebaseConfig = {
  apiKey: "AIzaSyDXdMboCNBT1c_2fObtKSmlr3d3_rzWPFI",
  authDomain: "fir-practice-99e79.firebaseapp.com",
  projectId: "fir-practice-99e79",
  storageBucket: "fir-practice-99e79.appspot.com",
  messagingSenderId: "739613437821",
  appId: "1:739613437821:web:255b7499e91bfe39fca614",
  measurementId: "G-7GZ4K9D8JT"
};

const app = initializeApp(firebaseConfig);
export const auth = getAuth(app);
export const googleProvider = new GoogleAuthProvider();