import React, { Component } from 'react';
import DashBoardComponent from '../components/dashboardComponent';
import GetUserStatisticsComponent from '../components/getUserStatisticsComponent';



class Dashboard extends Component {
    constructor(props) {
        super(props)
        this.state = {
            search: ""
        }
    }
    handleSearch = async (value) => {
        await this.setState({
            search: value
        })
    }

    render() {
        return (
            <div >
                <div><DashBoardComponent props={this.props} propsToDashboard={this.handleSearch} /></div>
                <div><GetUserStatisticsComponent props={this.props} propsToGetUserStatistics={this.state.search} /></div>
            </div>
        );
    }
}

export default Dashboard;