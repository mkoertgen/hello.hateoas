using System.Collections.Generic;
using Newtonsoft.Json.Linq;

namespace hello.hateoas
{
    internal static class TestData
    {
        // https://neo4j.com/docs/rest-docs/current/
        // https://developer.github.com/v3/#link-header
        // http://jsonapi.org/
        // TODO: ...
        // https://www.twilio.com/docs/api/rest
        // http://stateless.co/hal_specification.html

        public class TestCase
        {
            public string Pattern { get; set; } = "$..*";
            public JToken Input { get; set; }
            public IEnumerable<Link> Expected { get; set; }
        }


        public static readonly List<TestCase> TestCases = new List<TestCase>
        {
            new TestCase{ Input = JToken.Parse(@"{
  'extensions': {},
  'metadata': {
    'id': 18,
    'labels': [
      'User'
    ]
  },
  'paged_traverse': 'http://localhost:7474/db/data/node/18/paged/traverse/{returnType}{?pageSize,leaseTime}',
  'outgoing_relationships': 'http://localhost:7474/db/data/node/18/relationships/out',
  'outgoing_typed_relationships': 'http://localhost:7474/db/data/node/18/relationships/out/{-list|&|types}',
  'create_relationship': 'http://localhost:7474/db/data/node/18/relationships',
  'labels': 'http://localhost:7474/db/data/node/18/labels',
  'traverse': 'http://localhost:7474/db/data/node/18/traverse/{returnType}',
  'all_relationships': 'http://localhost:7474/db/data/node/18/relationships/all',
  'all_typed_relationships': 'http://localhost:7474/db/data/node/18/relationships/all/{-list|&|types}',
  'property': 'http://localhost:7474/db/data/node/18/properties/{key}',
  'self': 'http://localhost:7474/db/data/node/18',
  'incoming_relationships': 'http://localhost:7474/db/data/node/18/relationships/in',
  'properties': 'http://localhost:7474/db/data/node/18/properties',
  'incoming_typed_relationships': 'http://localhost:7474/db/data/node/18/relationships/in/{-list|&|types}',
  'data': {
    'followers': 640,
    'screen_name': 'DaisyDuck1990',
    'following': 503,
    'name': 'Sunflowers',
    'profile_image_url': 'http://pbs.twimg.com/profile_images/741758826798559233/u6uDWY6W_normal.jpg',
    'location': 'Entenhausen'
  }
}"),
      Expected = new [] {
new Link { Rel = "paged_traverse", Href = "http://localhost:7474/db/data/node/18/paged/traverse/{returnType}{?pageSize,leaseTime}"},
new Link { Rel = "outgoing_relationships", Href = "http://localhost:7474/db/data/node/18/relationships/out" },
new Link { Rel = "outgoing_typed_relationships", Href = "http://localhost:7474/db/data/node/18/relationships/out/{-list|&|types}" },
new Link { Rel = "create_relationship", Href = "http://localhost:7474/db/data/node/18/relationships" },
new Link { Rel = "labels", Href = "http://localhost:7474/db/data/node/18/labels" },
new Link { Rel = "traverse", Href = "http://localhost:7474/db/data/node/18/traverse/{returnType}" },
new Link { Rel = "all_relationships", Href = "http://localhost:7474/db/data/node/18/relationships/all" },
new Link { Rel = "all_typed_relationships", Href = "http://localhost:7474/db/data/node/18/relationships/all/{-list|&|types}" },
new Link { Rel = "property", Href = "http://localhost:7474/db/data/node/18/properties/{key}" },
new Link { Rel = "self", Href = "http://localhost:7474/db/data/node/18" },
new Link { Rel = "incoming_relationships", Href = "http://localhost:7474/db/data/node/18/relationships/in" },
new Link { Rel = "properties", Href = "http://localhost:7474/db/data/node/18/properties" },
new Link { Rel = "incoming_typed_relationships", Href = "http://localhost:7474/db/data/node/18/relationships/in/{-list|&|types}" },
new Link { Rel = "data.profile_image_url", Href = "http://pbs.twimg.com/profile_images/741758826798559233/u6uDWY6W_normal.jpg" }
}
            },

 new TestCase{ Input =  JToken.Parse(@"{
  'current_user_url': 'https://api.github.com/user',
  'current_user_authorizations_html_url': 'https://github.com/settings/connections/applications{/client_id}',
  'authorizations_url': 'https://api.github.com/authorizations',
  'code_search_url': 'https://api.github.com/search/code?q={query}{&page,per_page,sort,order}',
  'emails_url': 'https://api.github.com/user/emails',
  'emojis_url': 'https://api.github.com/emojis',
  'events_url': 'https://api.github.com/events',
  'feeds_url': 'https://api.github.com/feeds',
  'followers_url': 'https://api.github.com/user/followers',
  'following_url': 'https://api.github.com/user/following{/target}',
  'gists_url': 'https://api.github.com/gists{/gist_id}',
  'hub_url': 'https://api.github.com/hub',
  'issue_search_url': 'https://api.github.com/search/issues?q={query}{&page,per_page,sort,order}',
  'issues_url': 'https://api.github.com/issues',
  'keys_url': 'https://api.github.com/user/keys',
  'notifications_url': 'https://api.github.com/notifications',
  'organization_repositories_url': 'https://api.github.com/orgs/{org}/repos{?type,page,per_page,sort}',
  'organization_url': 'https://api.github.com/orgs/{org}',
  'public_gists_url': 'https://api.github.com/gists/public',
  'rate_limit_url': 'https://api.github.com/rate_limit',
  'repository_urlrepository_url': 'https://api.github.com/repos/{owner}/{repo}',
  'repository_search_url': 'https://api.github.com/search/repositories?q={query}{&page,per_page,sort,order}',
  'current_user_repositories_url': 'https://api.github.com/user/repos{?type,page,per_page,sort}',
  'starred_url': 'https://api.github.com/user/starred{/owner}{/repo}',
  'starred_gists_urlstarred_gists_url': 'https://api.github.com/gists/starred',
  'team_url': 'https://api.github.com/teams',
  'user_url': 'https://api.github.com/users/{user}',
  'user_organizations_url': 'https://api.github.com/user/orgs',
  'user_repositories_url': 'https://api.github.com/users/{user}/repos{?type,page,per_page,sort}',
  'user_search_url': 'https://api.github.com/search/users?q={query}{&page,per_page,sort,order}'
}"),
   Expected = new [] {
new Link { Rel = "current_user_url", Href = "https://api.github.com/user"},
new Link { Rel = "current_user_authorizations_html_url", Href = "https://github.com/settings/connections/applications{/client_id}"},
new Link { Rel = "authorizations_url", Href = "https://api.github.com/authorizations"},
new Link { Rel = "code_search_url", Href = "https://api.github.com/search/code?q={query}{&page,per_page,sort,order}"},
new Link { Rel = "emails_url", Href = "https://api.github.com/user/emails"},
new Link { Rel = "emojis_url", Href = "https://api.github.com/emojis"},
new Link { Rel = "events_url", Href = "https://api.github.com/events"},
new Link { Rel = "feeds_url", Href = "https://api.github.com/feeds"},
new Link { Rel = "followers_url", Href = "https://api.github.com/user/followers"},
new Link { Rel = "following_url", Href = "https://api.github.com/user/following{/target}"},
new Link { Rel = "gists_url", Href = "https://api.github.com/gists{/gist_id}"},
new Link { Rel = "hub_url", Href = "https://api.github.com/hub"},
new Link { Rel = "issue_search_url", Href = "https://api.github.com/search/issues?q={query}{&page,per_page,sort,order}"},
new Link { Rel = "issues_url", Href = "https://api.github.com/issues"},
new Link { Rel = "keys_url", Href = "https://api.github.com/user/keys"},
new Link { Rel = "notifications_url", Href = "https://api.github.com/notifications"},
new Link { Rel = "organization_repositories_url", Href = "https://api.github.com/orgs/{org}/repos{?type,page,per_page,sort}"},
new Link { Rel = "organization_url", Href = "https://api.github.com/orgs/{org}"},
new Link { Rel = "public_gists_url", Href = "https://api.github.com/gists/public"},
new Link { Rel = "rate_limit_url", Href = "https://api.github.com/rate_limit"},
new Link { Rel = "repository_urlrepository_url", Href = "https://api.github.com/repos/{owner}/{repo}"},
new Link { Rel = "repository_search_url", Href = "https://api.github.com/search/repositories?q={query}{&page,per_page,sort,order}"},
new Link { Rel = "current_user_repositories_url", Href = "https://api.github.com/user/repos{?type,page,per_page,sort}"},
new Link { Rel = "starred_url", Href = "https://api.github.com/user/starred{/owner}{/repo}"},
new Link { Rel = "starred_gists_urlstarred_gists_url", Href = "https://api.github.com/gists/starred"},
new Link { Rel = "team_url", Href = "https://api.github.com/teams"},
new Link { Rel = "user_url", Href = "https://api.github.com/users/{user}"},
new Link { Rel = "user_organizations_url", Href = "https://api.github.com/user/orgs"},
new Link { Rel = "user_repositories_url", Href = "https://api.github.com/users/{user}/repos{?type,page,per_page,sort}"},
new Link { Rel = "user_search_url", Href = "https://api.github.com/search/users?q={query}{&page,per_page,sort,order}"}
} },

new TestCase{
    Pattern = "$..links.*",
    Input = JToken.Parse(@"{
  'links': {
    'self': 'http://example.com/articles',
    'next': 'http://example.com/articles?page[offset]=2',
    'last': 'http://example.com/articles?page[offset]=10'
  },
  'data': [{
    'type': 'articles',
    'id': '1',
    'attributes': {
      'title': 'JSON API paints my bikeshed!'
    },
    'relationships': {
      'author': {
        'links': {
          'self': 'http://example.com/articles/1/relationships/author',
          'related': 'http://example.com/articles/1/author'
        },
        'data': { 'type': 'people', 'id': '9' }
      },
      'comments': {
        'links': {
          'self': 'http://example.com/articles/1/relationships/comments',
          'related': 'http://example.com/articles/1/comments'
        },
        'data': [
          { 'type': 'comments', 'id': '5' },
          { 'type': 'comments', 'id': '12' }
        ]
      }
    },
    'links': {
      'self': 'http://example.com/articles/1'
    }
  }],
  'included': [{
    'type': 'people',
    'id': '9',
    'attributes': {
      'first-name': 'Dan',
      'last-name': 'Gebhardt',
      'twitter': 'dgeb'
    },
    'links': {
      'self': 'http://example.com/people/9'
    }
  }, {
    'type': 'comments',
    'id': '5',
    'attributes': {
      'body': 'First!'
    },
    'relationships': {
      'author': {
        'data': { 'type': 'people', 'id': '2' }
      }
    },
    'links': {
      'self': 'http://example.com/comments/5'
    }
  }, {
    'type': 'comments',
    'id': '12',
    'attributes': {
      'body': 'I like XML better'
    },
    'relationships': {
      'author': {
        'data': { 'type': 'people', 'id': '9' }
      }
    },
    'links': {
      'self': 'http://example.com/comments/12'
    }
  }]
}"), Expected = new []{ 
 new Link { Rel = "links.self", Href = "http://example.com/articles"},
 new Link { Rel = "links.next", Href = "http://example.com/articles?page[offset]=2"},
 new Link { Rel = "links.last", Href = "http://example.com/articles?page[offset]=10"},
 new Link { Rel = "data[0].relationships.author.links.self", Href = "http://example.com/articles/1/relationships/author"},
 new Link { Rel = "data[0].relationships.author.links.related", Href = "http://example.com/articles/1/author"},
 new Link { Rel = "data[0].relationships.comments.links.self", Href = "http://example.com/articles/1/relationships/comments"},
 new Link { Rel = "data[0].relationships.comments.links.related", Href = "http://example.com/articles/1/comments"},
 new Link { Rel = "data[0].links.self", Href = "http://example.com/articles/1"},
 new Link { Rel = "included[0].links.self", Href = "http://example.com/people/9"},
 new Link { Rel = "included[1].links.self", Href = "http://example.com/comments/5"},
 new Link { Rel = "included[2].links.self", Href = "http://example.com/comments/12"},
}}
 };
    }
}