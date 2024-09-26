import { useState, useCallback, useEffect } from 'react';
import useService from './useService';
import {agents} from '../../agents';

const useGetUser = () => {
    const [currentUser, setcurrentUser] = useState('');
    const [errorCode, setErrorCode] = useState(2);
    const [message, setMessage] = useState('');
    const [userInfo, setUserInfo] = useState('');

    const url = agents.localhost + agents.getUser;
    console.log("current username 1", currentUser);
    const { response, loading, refetch: fetchService } = useService(
        'Getting user informations',
        'GET',
        `${url}?Username=${currentUser}`,
        null,
        undefined, 
        null
    );

    const handleSignUpResponse = useCallback((response) => {
        if (response?.status === 200) {
            setErrorCode(0);
            setUserInfo(response.data);
            console.log("user info:  ", response.data);
            setMessage('User informations are here!');
        } else {
            setErrorCode(1);
            setMessage(response?.title || 'An error occurred. Please try again.');
        }
    }, [errorCode]);

    const getUser = useCallback((
        username
    ) => {
        console.log("current username 37", username);
        setcurrentUser(username);
    }, []);

    useEffect(() => {
        if (currentUser !== '') {
            console.log("current username wwwwwwwwwwww", currentUser);
            fetchService();
        }
    }, [fetchService, currentUser]);

    useEffect(() => {
        if (response) {
            handleSignUpResponse(response);
        }
    }, [response, handleSignUpResponse]);

    return { userInfo, message, errorCode, loading, refetch: getUser };
};

export default useGetUser;
