import React, { Component } from 'react';
import RegistrationComponent from '../Components/registrationComponent.jsx';

class Registration extends Component {
    render() {
        return (
            <div>
                <RegistrationComponent props={this.props}/>
            </div>
        );
    }
}

export default Registration;