import styles from './BigBanner.module.css';

export default function BigBanner(){
    return (
      <>
        <section className={styles.block}>
            <div className={styles.rightBlock}>
                <button className={styles.btn}>New laptop</button>
                <h2 className={styles.bigTitle}>Sale up to 50% off</h2>
                <h4 className={styles.smallTitle}>12 inch hd display</h4>
                <button className={styles.btn}>Shop now</button>
            </div>
        </section>
      </>
    );
}
//background: url("@/../images/logo\ 1.svg");