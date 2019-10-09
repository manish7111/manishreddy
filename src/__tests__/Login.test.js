import React from 'react';
import {
  shallow
} from 'enzyme';
import Login from '../Components/loginComponent';
import '../setupTest'
/**
 * describe what we are testing
 **/
describe('Login Component', () => {
  /**
   * make our assertion and what we expect to happen 
   **/
  it('should render without throwing an error', () => {
    expect(shallow( < Login / > ).exists()).toBe(true)
  })
  /**
   * within the Login components describe function
   **/
  it('renders a email input', () => {
    expect(shallow( < Login / > ).find('#Email').length).toEqual(1)
  })
  it('renders a password input', () => {
    expect(shallow( < Login / > ).find('#Password').length).toEqual(1)
  })
  /**
   * within the Login components describe function
   **/
  describe('Email input', () => {
    it('should respond to change event and change the state of the Login Component', () => {
      const wrapper = shallow( < Login / > );
      wrapper.find('#Email').simulate('change', {
        target: {
          name: 'Email',
          value: 'charan@gmail.com'
        }
      });
      expect(wrapper.state('Email')).toEqual('charan@gmail.com');
    })
  })
  describe('Password input', () => {
    it('should respond to change event and change the state of the Login Component', () => {
      const wrapper = shallow( < Login / > );
      wrapper.find('#Password')
        .simulate('change', {
          target: {
            name: 'Password',
            value: 'charan'
          }
        });
      expect(wrapper.state('Password')).toEqual('charan');
    })
  })
})