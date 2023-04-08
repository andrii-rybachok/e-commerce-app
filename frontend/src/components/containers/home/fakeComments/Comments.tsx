
import usePagination from "@/customHooks/usePagination";
import styles from "./Comments.module.css"

interface IComment{
    avatarImg:string,
    name:string,
    text:string
}
const commentsEntities:IComment[] = [
    {
        avatarImg:"ava_1.png",
        name:"Savannah Nguyen",
        text:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper."
    },
    {
        avatarImg:"ava_2.png",
        name:"Esther Howard",
        text:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper."
    },
    {
        avatarImg:"ava_3.png",
        name:"Esther Howard",
        text:"Lorem ipsum dolor sit amet consectetur.Nec sit enim tellus faucibus bibendum ullamcorper."
    },
    {
        avatarImg:"ava_2.png",
        name:"Esther Howard",
        text:"Lorem ipsum dolor sit amet consectetur.Nec sit enim tellus faucibus bibendum ullamcorper."
    },
    {
        avatarImg:"ava_3.png",
        name:"Esther Howard",
        text:"Lorem ipsum dolor sit amet consectetur.Nec sit enim tellus faucibus bibendum ullamcorper."
    },
    {
        avatarImg:"ava_1.png",
        name:"Savannah Nguyen",
        text:"Lorem ipsum dolor sit amet consectetur.Nec sit enim tellus faucibus bibendum ullamcorper."
    },
]
export default function Comments(){
   const pageSystem = usePagination({maxItemsOnPage:3,
        itemsLength:commentsEntities.length});
    
    const comments = commentsEntities.map((comment,index)=>{
        return(
            <Comment comment={comment}/>
        )
    })
    let pagination= pageSystem.pagination;
    return(
        <section className={styles.block}>
            <div className={styles.comments}>
                {comments.slice(pagination.currentPage*pagination.maxProductsOnPage,pagination.currentPage*pagination.maxProductsOnPage+pagination.maxProductsOnPage)}
            </div>
                <div className={styles.indicators}>
                    {pageSystem.indicators}
                </div>
        </section>
    );
}
function Comment({comment}:{comment:IComment}){
    return (
      <div className={styles.commentBlock}>
        <div className={styles.topBlock}>
          <div className={styles.imgBlock}>
            <img src={"images/" + comment.avatarImg} alt="" />
          </div>
          <h4 className={styles.name}>{comment.name}</h4>
        </div>
        <div className={styles.text}>
          <p>{comment.text}</p>
        </div>
      </div>
    );
}