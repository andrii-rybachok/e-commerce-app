import styles from './ProsPage.module.css';

export default function ProsPage(){
    return (
        <section className={styles.block}>
            <div className={styles.pros}>
                <img src="images/pros_1.png" alt="" />
                <div>
                    <h3>Free delivery</h3>
                    <p>on order above $50,00</p>
                </div>
            </div>
            <div className={styles.pros}>
                <img src="/images/pros_2.png"  alt="" />
                <div>
                    <h3>Best quality </h3>
                    <p>best quality in low price</p>
                </div>
            </div>
            <div className={styles.pros}>
                <img src="/images/pros_3.png" alt="" />
                <div>
                    <h3>1 year warranty</h3>
                    <p>Avaliable warranty</p>
                </div>
            </div>
        </section>
    );
}