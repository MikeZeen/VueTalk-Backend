# Domain Models

## Post

```csharp
class Menu
{
	Post Create();

}
```

```json
{
	"id": "00000000-0000-0000-0000-000000000000",
	"name" : "Post Name",
	"text" : "This is some kind of post where we are talking about 3D Stuff",
	"averageRating" : 4.5,
	"createdDateTime": "2024-01-01T00:00:00.0000000Z",
	"updatedDateTime": "2024-01-01T00:00:00.0000000Z",
	"authorId" :  "00000000-0000-0000-0000-000000000000",
	"commentIds" : ["00000000-0000-0000-0000-000000000000"],
	"ratingIds" : ["00000000-0000-0000-0000-000000000000"],

}
```