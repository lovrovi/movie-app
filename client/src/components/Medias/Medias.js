import { useEffect, useState, useRef } from 'react'
import { useDispatch, useSelector } from 'react-redux'
import { getMedias } from '../../redux/actions/medias/medias';
import { RatingModal } from '../Ratings/RatingModal';
import { MediaCard } from './MediaCard';
import Button from '@mui/material/Button';
import './Medias.css'

export const Medias = ({ mediaType }) => {
    const [showModal, setModalVisibility] = useState(false);
    const [id, setId] = useState("");
    const [ammount, setAmmount] = useState(10);

    const isInitialMount = useRef(true)

    const dispatch = useDispatch()
    const medias = useSelector(state => state.medias.medias)

    useEffect(() => {
        dispatch(getMedias("", 10, mediaType))
    }, [dispatch, mediaType])

    const handleShowMore = () => {
        setAmmount(ammount + 10);
    }

    useEffect(() => {
        if (isInitialMount.current) {
            isInitialMount.current = false
        } else {
            dispatch(getMedias("", ammount, mediaType))
        }
    }, [ammount, mediaType, dispatch])

    const handleShowRatingModal = () => {
        setModalVisibility(!showModal)
    }

    const clickStarAction = (id) => {
        setId(id)
        handleShowRatingModal()
    }
    const mediasRender = () => {
        return medias.map((media, index) => {
            return (
                <MediaCard media={media} key={index} clickStar={clickStarAction} />
            )
        })
    }

    return (
        <div className="medias">
            <div className="mediaCardContainer">
                {mediasRender()}

                <RatingModal
                    id={id}
                    handleShowRatingModal={handleShowRatingModal}
                    showRatingModal={showModal}
                    mediaType={mediaType}
                />
            </div>

            {
                medias.length < ammount ? "" :
                    <Button
                        onClick={() => handleShowMore()}
                    >
                        Show More
                    </Button>
            }
        </div>
    )
}
