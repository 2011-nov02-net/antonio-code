-- Use column aliases
-- 1. list all customers (full names, customer ID, and country) who are not in the US
SELECT * FROM Customer where country <> 'US';
-- 2. list all customers from brazil
SELECT * FROM Customer where country = 'Brazil';
-- 3. list all sales agents
SELECT * FROM Employee where Title = 'Sales Support Agent';
-- 4. show a list of all countries in billing addresses on invoices.
select distinct BillingCountry from invoice;
-- 5. how many invoices were there in 2009, and what was the sales total for that year?
--    (extra challenge: find the invoice count sales total for every year, using one query)
select Year(invoicedate) as InvoiceYear, count(*) as TotalInvoices, sum(Total) as Total from invoice group by Year(invoicedate);
-- 6. how many line items were there for invoice #37?
select count(invoiceid) from invoiceline where invoiceid='37';
-- 7. how many invoices per country?
select BillingCountry, count(*) as TotalInvoices from invoice group by BillingCountry;
-- 8. show total sales per country, ordered by highest sales first.
select BillingCountry, sum(total) as Total from invoice group by BillingCountry order by Total;