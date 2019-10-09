import * as firebase from "firebase/app";
import "firebase/messaging";
// import firebase from 'firebase'
const firebaseConfig = {
    apiKey: "AIzaSyAFVrUPE6ZTrs1vTbgX0n8yUtpea8acBL4",
    authDomain: "react-1d5eb.firebaseapp.com",
    databaseURL: "https://react-1d5eb.firebaseio.com",
    projectId: "react-1d5eb",
    storageBucket: "",
    messagingSenderId: "23143272001",
    appId: "1:23143272001:web:7a02c0d979b3610d1a00c0",
    measurementId: "G-78XTVQ640Z"
  };
  const initializedFirebaseApp=firebase.initializeApp(firebaseConfig);
// const initializedFirebaseApp = firebase.initializeApp({
// // Project Settings => Add Firebase to your web app
// messagingSenderId: "23143272001",
// });
const messaging = initializedFirebaseApp.messaging();
messaging.usePublicVapidKey(
// Project Settings => Cloud Messaging => Web Push certificates
"BJ75EcKol2gLVvxlilvkwL9ZltujiYM7efcXyCmpavUxzWce7oRYHrL5ifNe4WI9c4m3v_Rcu7mY8Y25NJX8DVw"
);
export { messaging };