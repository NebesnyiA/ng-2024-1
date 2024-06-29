use RecipePlatform;

select * from Author

select * from Category

select count(*) c, AuthorId from Recipe group by AuthorId

select * from RecipeCategory

select *
from Recipe as r
inner join Author as a
on a.Id = r.AuthorId

select *
from Recipe as r
left outer join Author as a
on a.Id = r.AuthorId

select *
from Recipe as r
right outer join Author as a
on a.Id = r.AuthorId

select *
from Recipe as r
full join Author as a
on a.Id = r.AuthorId

select *
from Recipe as r
cross join Author

select * from Recipe

select * from Author

delete from Author where Id = 2

insert Author(id, Name)
values(5, 'Kriss')

update Recipe 
set 
	AuthorId = 4
where Id = 8

select * from RecipeCategory 

select r.Id as rId, c.Id as cId, r.Name, c.Name catName 
from RecipeCategory as rc
left join Recipe as r
on r.Id = rc.RecipeId
right join Category as c
on c.Id = rc.CategoryId
