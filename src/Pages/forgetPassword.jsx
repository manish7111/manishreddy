import React, { Component } from 'react';
import ForgetPasswordComponent from '../Components/forgetPasswordComponent.jsx';

class ForgetPassword extends Component {
    render() {
        return (
            <div>
            <ForgetPasswordComponent props={this.props}/>
            </div>
        );
    }
}

export default ForgetPassword;