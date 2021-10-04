import { useEffect, useRef, useState } from 'react'
import { useDispatch } from 'react-redux'
import _ from 'lodash'
import InputBase from '@material-ui/core/InputBase';
//import SearchIcon from '@material-ui/icons/Search';

export const SearchField = ({ value, name, handleChange, searchAction }) => {
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
                    dispatch(searchAction(value))
                }, 1000)
                return () => clearTimeout(timer);
            } else if (_.isEmpty(value)) {
                setErrorMsg()
                dispatch(searchAction(value))
            } else if (!value.trim()) {
                setErrorMsg("Search should not contain only empty space!")
            } else if (value.trim().length < 2) {
                setErrorMsg("Search must contain more than two characters!")
            }
        }
    }, [dispatch, value, searchAction])

    return (
        <div className="searchContainer">
            <div className="searchBox">
                <div>
                    <InputBase
                        type="text"
                        value={value || ''}
                        name={name}
                        onChange={handleChange}
                        placeholder="Search…"
                        inputProps={{ 'aria-label': 'search' }}
                    />
                </div>
                <div className="errorMsg">
                    <p>{errorMsg}</p>
                </div>
            </div>
        </div>
    )
}
