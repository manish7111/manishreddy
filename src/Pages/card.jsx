/*****************************************************************************************************
 *  @Purpose        : Here we have to create the Card that contains all required Card components.
 *  @file           : Card.jsx       
 *  @author         : Manish Reddy
 *  @version        : v0.1
 *  @since          : 12-09-2019
 *****************************************************************************************************/
import React, { Component } from 'react'
import CardComponent from '../Components/cardComponent.jsx'
export default class Card extends Component {
    render() {
        return (
            <div>
                <CardComponent props={this.props}/>
            </div>
        )
    }
}