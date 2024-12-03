import React, { useEffect, useState } from "react";

const FeedbackCard = ({ title, index }) => {
    const [upvotes, setUpvotes] = useState(0);
    const [downvote, setDownvote] = useState(0);

    return (
        <div className="my-0 mx-auto text-center w-mx-1200">
            <div className="flex wrap justify-content-center mt-30 gap-30">
                <div className="pa-10 w-300 card">
                    <h2>{title}</h2>
                    <div className="flex my-30 mx-0 justify-content-around">
                        <button className="py-10 px-15" onClick={() => { setUpvotes(upvotes + 1) }} data-testid={`upvote-btn-${index}`}>
                            👍 Upvote
                        </button>
                        <button className="py-10 px-15 danger" onClick={() => { setDownvote(downvote + 1) }} data-testid={`downvote-btn-${index}`}>
                            👎 Downvote
                        </button>
                    </div>
                    <p className="my-10 mx-0" data-testid={`upvote-count-${index}`}>
                        Upvotes: <strong>{upvotes}</strong>
                    </p>
                    <p className="my-10 mx-0" data-testid={`downvote-count-${index}`}>
                        Downvotes: <strong>{downvote}</strong>
                    </p>
                </div>
            </div>
        </div>
    );
}

const FeedbackSystem = () => {
    return (
        <>
            <FeedbackCard title="Readability" index={0} />
            <FeedbackCard title="Performance" index={1} />
            <FeedbackCard title="Security" index={2} />
            <FeedbackCard title="Documentation" index={3} />
            <FeedbackCard title="Testing" index={4} />
        </>
    )
};

export default FeedbackSystem;