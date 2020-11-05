//const { bool } = require("joi");

import Boom from 'boom'

class PostsController {
    constructor(Posts){
        this.Posts = Posts
    }

    async find(request){
        const { id } = request.params
        const query = {}

        if (id) {
            query._id = id
        }

        try {

            const users = await this.Users.find(query)
            return { users }
            
        } catch (error) {
            return Boom.badRequest('Failed to find user')
        }
    }

    async create(request, h, err) {
        try {

            const post = new this.Posts(request.payload)
            await post.save()

            return h.response().code(201)
        } catch (error) {
            return Boom.badRequest(error)
        }
    }

    async update(request, h) {
        
        const { id } = request.params

        try {
            const updatedPosts = await this.Posts.findOneAndUpdate({ _id: id }, request.payload, {
                new: true,
            });

            if (updatedPosts) {
                return h.response().code(200)
            }

            return Boom.badRequest('Could not update the user')

            
        } catch (error) {
            return Boom.badRequest(error)
        }
    }

    async delete(request, h) {
        const { id } = request.params

        try{
            const deletedPost = await this.Posts.findOneAndUpdate({ _id: id})

            if (deletedPost) {
                return h.response().code(200)
            }
        }catch(error){
            return Boom.badRequest(error)
        }
    }
}

export default PostsController