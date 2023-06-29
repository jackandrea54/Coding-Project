-- Answer to 3.1
WITH a AS (
    SELECT po.product_id, po.list_price*quantity AS total , pc.*, ordi.order_id, cus.customer_id  FROM products po 
    JOIN product_categories pc 
    ON po.category_id = pc.category_id
    JOIN order_items ordI ON ordI.product_id = po.product_id
    JOIN orders ord ON ord.order_id = ordi.order_id
    JOIN customers cus ON cus.customer_id = ord.customer_id
)
, b AS (
    SELECT sum(total) AS sumTotal, category_name, customer_id
    FROM a 
    GROUP BY category_name, customer_id
)
,c AS (
    SELECT MAX(sumTotal) AS sumTotal, category_name FROM b GROUP BY category_name
)

SELECT b.category_name,  contacts.first_name || ' ' || contacts.lASt_name AS fullName, b.sumTotal AS Revenues, contacts.phONe FROM b 
JOIN c ON c.category_name = b.category_name and c.sumTotal = b.sumTotal
JOIN customers ON customers.customer_id = b.customer_id
JOIN contacts ON contacts.customer_id = customers.customer_id

-- Answer to 3.2
WITH customer_revenue AS (
  SELECT ct.first_name || ' ' || ct.lASt_name AS fullName, c.website, p.product_name, oi.quantity * oi.unit_price AS revenue,
    ROW_NUMBER() OVER (PARTITION BY c.customer_id ORDER BY oi.quantity * oi.unit_price DESC) AS rn
  FROM customers c
   JOIN contacts ct ON c.customer_id = ct.customer_id
   JOIN orders o ON c.customer_id = o.customer_id
   JOIN order_items oi ON o.order_id = oi.order_id
   JOIN products p ON oi.product_id = p.product_id
)
SELECT fullName, website, product_name, revenue
FROM (
  SELECT fullName, website, product_name, revenue,
    ROW_NUMBER() OVER (PARTITION BY fullName ORDER BY revenue DESC) AS rn
  FROM customer_revenue
) subquery
WHERE rn <= 3
ORDER BY fullName ASC, revenue DESC;




