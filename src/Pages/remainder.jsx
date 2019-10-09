import React, { Component } from 'react'
import RemainderComponent from '../Components/remainderComponent'
import DashBoardComponent from '../Components/dashboardComponent'
export default class Remainder extends Component {
    render() {
     
        
        return (
            <div>
            <div><DashBoardComponent></DashBoardComponent></div>
            <div className='remainder-notes-alignment'><RemainderComponent props={this.props}/></div>
            </div>
        )
    }
}
