'use strict';


/**
 * Delete the connection design item
 * Delete the single design item which is given by its unique id
 *
 * id ConDesignItemId The ID of the required connection design item
 * no response value expected for this operation
 **/
exports.deleteConDesignItem = function(id) {
  return new Promise(function(resolve, reject) {
    resolve();
  });
}


/**
 * Get the connection design item
 * Get data of the single design item which is given by its unique id
 *
 * id ConDesignItemId The ID of the required connection design item
 * returns ConDesignItem
 **/
exports.getConDesignItem = function(id) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91",
  "version" : "version"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Get all connection design items from the given connection design set
 *
 * id ConDesignSetId The ID of the required connection design set
 * returns List
 **/
exports.getConDesignItems = function(id) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = [ {
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91",
  "version" : "version"
}, {
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91",
  "version" : "version"
} ];
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Create or modify the connection design item
 * Create or modify the connection design item and return the updated instance from the database
 *
 * body ConDesignItem An object containing connection design item information
 * returns ConDesignItem
 **/
exports.postConDesignItem = function(body) {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "name" : "name",
  "description" : "description",
  "id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91",
  "version" : "version"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}


/**
 * Publish connection design items
 * Publish selected connection design items from Idea connection project to the given connection design set
 *
 * returns PublishWorkItem
 **/
exports.project_publishPOST = function() {
  return new Promise(function(resolve, reject) {
    var examples = {};
    examples['application/json'] = {
  "job-id" : "046b6c7f-0b8a-43b9-b35d-6489e6daee91"
};
    if (Object.keys(examples).length > 0) {
      resolve(examples[Object.keys(examples)[0]]);
    } else {
      resolve();
    }
  });
}

