import React, { useEffect } from 'react';

function Slides({ slides }) {
    const [currentSlide, setCurrentSlide] = React.useState(0);
    const [nextDisabled, setNextDisabled] = React.useState(false);
    const [prevDisabled, setPrevDisabled] = React.useState(true);
    const [restartDisabled, setRestartDisabled] = React.useState(true);

    const nextSlide = () => {
        if (currentSlide < slides.length) {
            setCurrentSlide((currentSlide + 1) % slides.length);
        } else {
            setCurrentSlide(0);
        }
    }
    const prevSlide = () => {
        if (currentSlide < slides.length) {
            setCurrentSlide((currentSlide - 1) % slides.length);
        } else {
            setCurrentSlide(0);
        }
    }
    const restartClick = () => {
        setCurrentSlide(0);
    }

    useEffect(() => {
        if (currentSlide === slides.length - 1) {
            setNextDisabled(true);
        } else {
            setNextDisabled(false);
        }
        if (currentSlide === 0) {
            setPrevDisabled(true);
        } else {
            setPrevDisabled(false);
        }
        if (currentSlide === 0) {
            setRestartDisabled(true);
        } else {
            setRestartDisabled(false);
        }
    }, [currentSlide]);

    return (
        <div>
            <div id="navigation" className="text-center">
                <button data-testid="button-restart" disabled={restartDisabled} onClick={restartClick} className="small outlined">Restart</button>
                <button data-testid="button-prev" disabled={prevDisabled} onClick={prevSlide} className="small">Prev</button>
                <button data-testid="button-next" disabled={nextDisabled} onClick={nextSlide} className="small">Next</button>
            </div>
            <div id="slide" className="card text-center">
                <h1 data-testid="title">{slides[currentSlide]?.title}</h1>
                <p data-testid="text">{slides[currentSlide]?.text}</p>
            </div>
        </div>
    );
}

export default Slides;
