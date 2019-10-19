import React from 'react';
import {
  shallow
} from 'enzyme';
import RegistrationComponent from '../components/registrationComponent';
import '../setupTest'
/**
 * describe what we are testing
 **/
describe('Registration Component', () => {
  /**
   * make our assertion and what we expect to happen 
   **/
  it('should render without throwing an error', () => {
    expect(shallow( < RegistrationComponent / > ).exists()).toBe(true)
  })
  /**
   * within the Login components describe function
   **/
  it('renders a email input', () => {
    expect(shallow( < RegistrationComponent / > ).find('#Email').length).toEqual(1)
  })
  it('renders a firstName input', () => {
    expect(shallow( < RegistrationComponent / > ).find('#FirstName').length).toEqual(1)
  })
  it('renders a lastName input', () => {
    expect(shallow( < RegistrationComponent / > ).find('#LastName').length).toEqual(1)
  })
  it('renders a password input', () => {
    expect(shallow( < RegistrationComponent / > ).find('#Password').length).toEqual(1)
  })
  /**
   * within the Registration components describe function
   **/
  describe('Email input', () => {
      debugger;
    it('should respond to change event and change the state of the Registration Component', () => {
      const wrapper = shallow( < RegistrationComponent / > );
      wrapper.find('#Email').simulate('change', {
        target: {
          name: 'Email',
          value: 'manish7111@gmail.com'
        }
      });
      expect(wrapper.state('Email')).toEqual('manish7111@gmail.com');
    })
  })
  describe('FirstName input', () => {
    it('should respond to change event and change the state of the Registration Component', () => {
      const wrapper = shallow( < RegistrationComponent / > );
      wrapper.find('#FirstName')
        .simulate('change', {
          target: {
            name: 'FirstName',
            value: 'manish'
          }
        });
      expect(wrapper.state('FirstName')).toEqual('manish');
    })
  })
  describe('LastName input', () => {
    it('should respond to change event and change the state of the Registration Component', () => {
      const wrapper = shallow( < RegistrationComponent / > );
      wrapper.find('#LastName')
        .simulate('change', {
          target: {
            name: 'LastName',
            value: 'reddy'
          }
        });
      expect(wrapper.state('LastName')).toEqual('reddy');
    })
  })
  describe('Password input', () => {
    it('should respond to change event and change the state of the Registration Component', () => {
      const wrapper = shallow( < RegistrationComponent / > );
      wrapper.find('#Password')
        .simulate('change', {
          target: {
            name: 'Password',
            value: 'manishreddy'
          }
        });
      expect(wrapper.state('Password')).toEqual('manishreddy');
    })
  })
})