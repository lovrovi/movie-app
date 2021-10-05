import { useEffect, useRef, useState } from 'react'
import { useDispatch } from 'react-redux'
import _ from 'lodash'
import InputBase from '@material-ui/core/InputBase';
import './SearchField.css'

export const SearchField = ({ value, name, handleChange, searchAction, currentTab }) => {
    const dispatch = useDispatch()

    const isInitialMount = useRef(true)

    const [errorMsg, setErrorMsg] = useState()

    useEffect(() => {
        if (isInitialMount.current) {
            isInitialMount.current = false
        } else {
            if (!_.isEmpty(value) && value.trim().length >= 2) {
                setErrorMsg()
                const timer = setTimeout(() => {
                    dispatch(searchAction(value, 10, currentTab))
                }, 1000)
                return () => clearTimeout(timer);
            } else if (_.isEmpty(value)) {
                setErrorMsg()
                dispatch(searchAction(value, 10, currentTab))
            } else if (!value.trim()) {
                setErrorMsg("Search should not contain only empty space!")
            } else if (value.trim().length < 2) {
                setErrorMsg("Search must contain more than two characters!")
            }
        }
    }, [dispatch, value, searchAction, currentTab])

    return (
        <div className="searchContainer">
            <InputBase
                type="text"
                value={value || ''}
                name={name}
                onChange={handleChange}
                placeholder="Search..."
                inputProps={{ 'aria-label': 'search' }}
            />
            <div className="errorMsg">
                {errorMsg}
            </div>
        </div>
    )
}
