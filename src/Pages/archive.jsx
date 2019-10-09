import React, { Component } from 'react'
import ArchiveComponent from '../Components/archiveComponent'
import DashBoardComponent from '../Components/dashboardComponent'
export default class Archive extends Component {
    render() {
        return (
            <div>
            <div><DashBoardComponent></DashBoardComponent></div>
            <div className='trash-notes-alignment'><ArchiveComponent props={this.props}/></div>
            </div>
        )
    }
}
