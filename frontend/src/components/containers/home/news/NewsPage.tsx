import INews from "@/types/news/INews";
import styles from "./NewsPage.module.css"
import usePagination from "@/customHooks/usePagination";
import { Link } from "react-router-dom";

export default function News(){
    const newsEntities:INews[]=[
        {
            title:"Who avoids a pain that produces?",
            date:new Date(2022,11,24),
            description:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper. Phasellus tristique aenean at lorem sed scelerisque.",
            author:"By spacing tech",
            image:"news_1.png"
        },
        {
            title:"Who avoids a pain that produces?",
            date:new Date(2020,10,24),
            description:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper. Phasellus tristique aenean at lorem sed scelerisque.",
            author:"By spacing tech",
            image:"news_1.png"
        },
        {
            title:"Who avoids a pain that produces?",
            date:new Date(2022,11,24),
            description:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper. Phasellus tristique aenean at lorem sed scelerisque.",
            author:"By spacing tech",
            image:"news_2.png"
        },
        {
            title:"Who avoids a pain that produces?",
            date:new Date(2020,10,24),
            description:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper. Phasellus tristique aenean at lorem sed scelerisque.",
            author:"By spacing tech",
            image:"news_2.png"
        },
        {
            title:"Who avoids a pain that produces?",
            date:new Date(2022,11,24),
            description:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper. Phasellus tristique aenean at lorem sed scelerisque.",
            author:"By spacing tech",
            image:"news_1.png"
        },
        {
            title:"Who avoids a pain that produces?",
            date:new Date(2020,10,24),
            description:"Lorem ipsum dolor sit amet consectetur. Nec sit enim tellus faucibus bibendum ullamcorper. Phasellus tristique aenean at lorem sed scelerisque.",
            author:"By spacing tech",
            image:"news_1.png"
        },
    ]
    const pageSystem = usePagination({maxItemsOnPage:2,
        itemsLength:newsEntities.length});
    
    const newsItems =newsEntities.map((item,index)=>{
        return(
            <NewsItem key={index} news={item} />
        )
    })
    let pagination= pageSystem.pagination;
    return (
      <section>
        <h2 className={styles.mainTitle}>Latest news</h2>
        <div className={styles.news}>
          {newsItems.slice(
            pagination.currentPage * pagination.maxProductsOnPage,
            pagination.currentPage * pagination.maxProductsOnPage +
              pagination.maxProductsOnPage
          )}
        </div>
        <div className={styles.indicators}>
            {pageSystem.indicators}
        </div>
      </section>
    );
}

export function NewsItem({news}:{news:INews}){
    return(
        <Link to={"#"}>
            <div className={styles.newsBlock}>
                <div className={styles.imgBlock}>
                    <img src={"images/"+news.image} alt="" />
                </div>
                <div className={styles.textBlock}>
                    <div className={styles.dateBlock}>
                        <h4>{news.date.getDay()+","+news.date.toLocaleString('en-us',{month:'short'})+","+news.date.getFullYear()}</h4>
                    </div>
                    <h3>{news.title}</h3>
                    <p>
                        {news.description}
                    </p>
                    <h6>{news.author}</h6>
                </div>
            </div>
        </Link>
    );
}