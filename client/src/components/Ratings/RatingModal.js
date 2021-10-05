import { useState } from 'react'
import { Modal } from '../../containers/Modal/Modal'
import { Rating } from 'react-simple-star-rating'
import { useDispatch } from 'react-redux'
import { postRating } from '../../redux/actions/ratings/ratings'
import Button from '@mui/material/Button';
import './RatingModal.css'

export const RatingModal = ({ handleShowRatingModal, showRatingModal, id, mediaType }) => {
    const [rating, setRating] = useState(0) // initial rating value
    const dispatch = useDispatch()

    const handleRating = (rate) => {
        setRating(rate)
    }

    const handlePostRating = () => {
        dispatch(postRating(rating, id, mediaType))
        handleShowRatingModal()
    }
    return (
        <Modal
            handleShowModal={handleShowRatingModal}
            open={showRatingModal}
            modalTitle="Rating"
        >
            <div className="modalContent">
                <Rating onClick={handleRating} ratingValue={rating} />
                <Button
                    size="small"
                    variant="contained"
                    onClick={() => handlePostRating()}>
                    Sumbit
                </Button>
            </div>
        </Modal>
    )
}