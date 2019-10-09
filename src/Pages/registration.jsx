import React, { Component } from 'react';
import RegistrationComponent from '../Components/registrationComponent.jsx';

class Registration extends Component {
    render() {
        console.log("id in register page------------>>>",this.props);
        
        return (
            <div>
                <RegistrationComponent props={this.props}/>
            </div>
        );
    }
}

export default Registration;