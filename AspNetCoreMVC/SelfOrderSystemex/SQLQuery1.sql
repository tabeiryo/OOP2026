UPDATE dbo.Products 
SET ImagePath = N'~/images/products/aisutea.jpg' 
WHERE Id = 4; 
SELECT @@ROWCOUNT AS UpdatedRows;


select * from dbo.Products;
