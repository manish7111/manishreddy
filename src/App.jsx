import React, { Component } from 'react';
import { BrowserRouter as Router, Switch, Route } from 'react-router-dom'
import './App.css';
import Login from './Pages/login.jsx'
import ForgetPassword from './Pages/forgetPassword.jsx';
import Registration from './Pages/registration.jsx';
import Dashboard from './Components/dashboard';
export default class App extends Component {
    render() {
        return (
            <div>
                <Router>
                    <Switch>
                        <Route path="/register" component={Registration}></Route>
                        <Route path="/login" component={Login}></Route>
                        <Route path="/" exact component={Login}></Route>
                        <Route path="/forget" component={ForgetPassword}></Route>
                        <Route path="/dashboard" component={Dashboard}></Route>
                    </Switch>
                </Router>
            </div>
        )
    }
}