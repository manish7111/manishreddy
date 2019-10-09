import React, { Component } from 'react'
import DashBoardComponent from '../Components/dashboardComponent'
import GetAllReminderComponent from '../Components/getAllReminderComponent'
export default class GetReminder extends Component {
    render() {
        console.log("props from reminder page",this.props);
        return (
            <div>
            <div><DashBoardComponent></DashBoardComponent></div>
            <div className='remainder-notes-alignment'><GetAllReminderComponent props={this.props}/></div>
            </div>
        )
    }
}
