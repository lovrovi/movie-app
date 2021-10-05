import React from 'react'
import { AiFillStar } from "react-icons/ai"
import Card from '@mui/material/Card';
import CardActions from '@mui/material/CardActions';
import CardContent from '@mui/material/CardContent';
import CardMedia from '@mui/material/CardMedia';
import Button from '@mui/material/Button';
import Typography from '@mui/material/Typography';

export const MediaCard = ({ media, clickStar }) => {

    const actors = () => {
        let cast = media.cast.map((actor, index) => {
            return actor.name
        })
        return cast.join(", ")
    }

    return (
        <Card sx={{ minWidth: 200, width: 300 ,minHeight: 400, margin: 2 }}>
            <CardMedia
                component="img"
                height="200"
                image={media.image}
                alt=""
            />
            <CardContent>
                <Typography gutterBottom variant="h5" component="div">
                    {media.title}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    Rating: {media.rating} <AiFillStar />
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    Relese date: {media.releaseDate}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    Description: {media.description}
                </Typography>
                <Typography variant="body2" color="text.secondary">
                    Cast: {actors()}
                </Typography>
            </CardContent>
            <CardActions>
                <Button
                    onClick={() => clickStar(media.id)}
                    size="small">
                    Rate
                </Button>
            </CardActions>
        </Card>
    )
}
