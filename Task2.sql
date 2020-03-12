SELECT a.Title, t.Name FROM Articles a
LEFT JOIN ArticleTags ta ON a.Id = ta.ArticleId
LEFT JOIN Tags t ON t.Id = ta.TagId