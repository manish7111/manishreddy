import React, { Component } from 'react';
import GetAllNotesComponent from '../Components/getAllNotesComponent.jsx';
import CreateNoteComponent from '../Components/createNoteComponent.jsx';
import DashBoardComponent from '../Components/dashboardComponent.jsx';
import PinComponent from '../Components/pinComponent.jsx'


class Dashboard extends Component {
    constructor(props) {
        super(props)
        this.state = {
            list: false,
            Search: ""
        }
        this.createNotesRef = React.createRef()
    }
    handleList = async (value) => {
        await this.setState({
            list: value
        })
        console.log("props in dashboard page", this.state.list);

    }
    handleSearch = async (value) => {
        await this.setState({
            Search: value
        })
    }
    handleCreateNote = (value) => {
        console.log("value of create notes props is ", value);
        this.createNotesRef.current.DisplayNotes(value)
    }
    render() {
        return (
            <div >
                <div><DashBoardComponent listview={this.handleList}
                    searchPropsToGetNotes={this.handleSearch} /></div>
                <div><CreateNoteComponent createNoteProps={this.handleCreateNote}></CreateNoteComponent></div>
                <div className='notes-alignment'><PinComponent list={this.state.list} /></div>
                <div className='notes-alignment'>
                    <GetAllNotesComponent props={this.props}
                        list={this.state.list}
                        searchProps={this.state.Search}
                        ref={this.createNotesRef}
                    />
                </div>

            </div>
        );
    }
}

export default Dashboard;