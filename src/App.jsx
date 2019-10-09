import React, { Component } from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import './App.css';
import Login from './Pages/login.jsx'
import ForgetPassword from './Pages/forgetPassword.jsx';
import Registration from './Pages/registration.jsx';
import Dashboard from './Pages/dashboard';
import Card from './Pages/card.jsx';
import ResetPassword from './Pages/resetPassword.jsx'
import Trash from './Pages/trash';
import Archive from './Pages/archive'
import RemainderComponent from './Components/remainderComponent'
import GetReminder from './Pages/getReminder';
import { messaging } from './init-fcm';
import Label from './Pages/label';
// import firebase from 'firebase'
// const config = {
//     apiKey: "AIzaSyAFVrUPE6ZTrs1vTbgX0n8yUtpea8acBL4",
//     authDomain: "react-1d5eb.firebaseapp.com",
//     databaseURL: "https://react-1d5eb.firebaseio.com",
//     projectId: "react-1d5eb",
//     storageBucket: "",
//     messagingSenderId: "23143272001",
//     appId: "1:23143272001:web:7a02c0d979b3610d1a00c0",
//     measurementId: "G-78XTVQ640Z"
//   };
// firebase.initializeApp(config);
// const messaging=firebase.messaging()
export default class App extends Component {
//  componentDidMount(){
//    messaging.requestPermission().then( function(){
//         console.log("have permission");
//      messaging.getToken().then(function(token){
//         console.log("token ",token);

//      })
        

//     }).then(function(token){
//         console.log("token ",token);
        
//     })
//     // refreshToken= messaging.onTokenRefresh(function(token){
//     //     console.log("token"+token);
        
//     // })
//     .catch(function(err){
//         console.log("Unable to get permission to notify.", err);

//     })
//    messaging.onMessage((payload) => console.log('Message received. ', payload));
  
// navigator.serviceWorker.addEventListener("message",(message)=>console.log("hi  hello ",message));
// }

    render() {
        
        return (
            <div >
                <Router>
                    <Switch>
                        <Route path="/register" component={Registration}></Route>
                        <Route path="/login" component={Login}></Route>
                        <Route path="/" exact component={Login}></Route>
                        <Route path="/forget" component={ForgetPassword}></Route>
                        <Route path="/dashboard" component={Dashboard}></Route>
                        <Route path="/card" component={Card}></Route>
                        <Route path="/reset" component={ResetPassword}></Route>
                        <Route path="/trash" component={Trash}></Route>
                        <Route path="/archive" component={Archive}></Route>
                        <Route path="/reminder" component={GetReminder}></Route>
                        <Route path="/label" component={Label}></Route>
                    </Switch>
                </Router>
            </div>
        )
    }
}