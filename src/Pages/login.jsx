import React, { Component } from 'react';
import LoginComponent from '../Components/loginComponent.jsx';
class Login extends Component {
    render() {
        return (
            <div>
                <LoginComponent props={this.props}/>
            </div>
        );
    }
}
export default Login;