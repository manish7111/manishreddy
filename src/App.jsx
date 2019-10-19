import React, { Component } from 'react';
import Registration from './components/registrationComponent';
import Login from './components/loginComponent';
import ForgetPassword from './components/forgetPasswordComponent';
import ResetPassword from './components/resetPasswordComponent';
import Dashboard from './pages/dashboard'
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom';
import '../src/App.css'

export default class App extends Component {
    render() {
        return (
            <div >
            <Router>
                <Switch>
                    <Route path="/register" component={Registration}></Route>
                    <Route path="/login" component={Login}></Route>
                    <Route path="/" exact component={Login}></Route>
                    <Route path="/forget" component={ForgetPassword}></Route>
                    <Route path="/reset" component={ResetPassword}></Route>
                    <Route path="/dashboard" component={Dashboard}></Route>              
                </Switch>
            </Router>
        </div>
        );
    }
}