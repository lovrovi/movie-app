import React from 'react'
import './MovieCard.css'

export const MovieCard = ({movie}) => {
    return (
        <div className="movieCard">
            <div className="movieCardRow">
                <span>{movie.title}</span>
                <span>{movie.rating} stars</span>
            </div>

        </div>
    )
}
