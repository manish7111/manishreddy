import React, { Component } from 'react';
import ResetPasswordComponent from '../Components/resetPasswordComponent.jsx';

class ResetPassword extends Component {
    render() {
        return (
            <div>
            <ResetPasswordComponent props={this.props}/>
            </div>
        );
    }
}

export default ResetPassword;