//import { Server } from 'hapi'
import Joi from 'joi'

import PostsController from '../controllers/posts'
import PostsModel from '../models/posts'

const PostsController = new PostsController(PostsModel)

const PostsRoute = (server) => {

    server.route({
        method: 'GET',
        path: '/posts/{id?}',
        handler: (require) => PostsController.find(request)
    })

    server.route({
        method: 'POST',
        path: '/users',
        handler: (request, h) => usersController.create(request, h),
        options: {
            validate: {
                payload: {
                    title: Joi.string(),
                    content: Joi.string(),
                    author: Joi.string().email()
                }
            }
        }
    })

    server.route({
        method: 'PUT',
        path: '/users/{id}',
        handler: (request, h) => usersController.update(request, h),
        options: {
            validate: {
                payload: {
                    title: Joi.string(),
                    content: Joi.string(),
                    author: Joi.string().email()
                }
            }
        }
    })

    server.route({
        method: 'DELETE',
        path: '/users/{id}',
        handler: (request, h) => usersController.delete(request, h)
    })

}
module.exports = PostsRoute