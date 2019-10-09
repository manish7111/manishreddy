import React, { Component } from 'react'
import DashBoardComponent from '../Components/dashboardComponent'
import DisplayLabel from '../Components/displayLabel'
export default class Label extends Component {
    constructor(props) {
        super(props)
        this.state = {
            list: false,
            Search: ""
        }
    }
    handleList = async (value) => {
        await this.setState({
            list: value
        })
        console.log("props in dashboard page", this.state.list);

    }
    handleSearch = async (value) => {
      await  this.setState({
            Search: value
        })
    }
    render() {
        return (
            <div>
            <div><DashBoardComponent listview={this.handleList}
            searchPropsToGetNotes={this.handleSearch}></DashBoardComponent></div>
            <div><DisplayLabel props={this.props}
            list={this.state.list}
            searchProps={this.state.Search}></DisplayLabel></div>
            </div>
        )
    }
}
