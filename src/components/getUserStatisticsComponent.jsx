import React, { Component } from 'react';
import { Table, TableCell, TableBody, TableHead, Paper, TableRow, Divider, Card, List, Button } from '@material-ui/core';
import { withRouter } from 'react-router-dom'
import { InputBase } from '@material-ui/core';
import { getUserDetails } from '../services/userServices'

function searchValue(search) {
    return function searchData(searchEmail) {
        return searchEmail.Email.includes(search)
    }
}
class GetUserStatisticsComponent extends Component {
    constructor(props) {
        super(props);
        this.state = {
            users: [],
            Id: "",
            Email: "",
            LoginTime: "",
            Service: "",
            basicCount: "",
            advanceCount: "",
            NotesCount: "",
            listPerPage: 15,
            startIndex: 0,
            endIndex: 5,
            currentIndex: 1,
            previous:"<<",
            next:">>"
        }
    }
    componentDidMount() {
        this.getUser()
    }
    getUser = () => {
        console.log("in..........?????????");

        getUserDetails().then((response) => {
            console.log('response is after getting', response);
            this.setState({
                users: response.data.list,
                basicCount: response.data.basicCount,
                advanceCount: response.data.advanceCount,

            })
            console.log("list of users is", this.state.users);

        })
    }
    prevPage = async() => {
        await  this.setState({
              startIndex: this.state.startIndex - 1,
              endIndex: this.state.endIndex - 1,
              currentIndex: this.state.currentIndex - 1
          })
      }
      nextPage =async () => {
         await this.setState({
              startIndex: this.state.startIndex + 1,
              endIndex: this.state.endIndex + 1,
              currentIndex: this.state.currentIndex + 1
          })
      }
      pageNumber = async(event) => {
          console.log("taget id===>", event.target.id);
         await this.setState({
              currentIndex: Number(event.target.id)
          })
          console.log("page number==>", this.state.currentIndex);
      }
  
    render() {
        const pageNumbers = [];
        for (let i = 1; i <=Math.ceil(this.state.users.length / this.state.listPerPage); i++) {
            pageNumbers.push(i);
        }
        console.log("page numbers Are", pageNumbers)
        const { startIndex, endIndex, currentIndex, listPerPage } = this.state;
        const lastUser = (currentIndex * listPerPage);
        const firstUser = (lastUser - listPerPage);
        const userList = this.state.users.slice(firstUser, lastUser)
        console.log("userList is ", userList);
        const renderPageNumber = pageNumbers.slice(startIndex, endIndex).map(item => {
            return (
                <div>
                    <Button style={{ width: "42px" }} onClick={(event) => this.pageNumber(event, item)} id={item}>
                        {item}
                    </Button>
                </div>
            )
        })

        return (
            <div>
                <div className="cards">
                    <Card className='basic-card' style={{ backgroundColor: "cadetblue" }}>
                        <div>
                            <b>Count of Basic Service</b>
                        </div>
                        <Divider />
                        <div className="number-adjust"><b>{this.state.basicCount}</b></div>
                    </Card>
                    <Card className='Advance-card' style={{ backgroundColor: "cadetblue" }}>
                        <div>
                            <b>Count of Advance Service</b>
                        </div>
                        <Divider />
                        <div className="number-adjust"><b>{this.state.advanceCount}</b></div>
                    </Card>
                </div>
                <Paper className="table">
                    <Table className="table-adjust" style={{ backgroundColor: "gray" }}>
                        <TableHead>
                            <TableRow>
                                <TableCell><b>Id</b></TableCell>
                                <TableCell align="left"><b>Email</b></TableCell>
                                <TableCell align="left"><b>Login Date & Time</b></TableCell>
                                <TableCell align="left"><b>Service</b></TableCell>
                                <TableCell align="left"><b>Notes Count</b></TableCell>
                            </TableRow>
                        </TableHead>
                        <TableBody>
                            {userList.filter(searchValue(this.props.propsToGetUserStatistics)).map(key => (
                                <TableRow key={key.id}>
                                    <TableCell component="th" scope="row">
                                        {key.Id}
                                    </TableCell>
                                    <TableCell align="left">{key.Email}</TableCell>
                                    <TableCell align="left">{key.LoginTime}</TableCell>
                                    <TableCell align="left">{key.Service}</TableCell>
                                    <TableCell align="left"><List>{key.NotesCount}</List></TableCell>
                                </TableRow>
                            ))}
                        </TableBody>
                    </Table>
                </Paper>
                <div className="page-list" colSpan="4">
                <Button onClick={this.prevPage} variant="contained" color="grey">
                <b>{this.state.previous}</b>
                
                </Button>
                {renderPageNumber}
                <Button onClick={this.nextPage} variant="contained" color="gray">
                <b>{this.state.next}</b>
                </Button>
                </div>
            </div>
        )


    }
}

export default withRouter(GetUserStatisticsComponent);