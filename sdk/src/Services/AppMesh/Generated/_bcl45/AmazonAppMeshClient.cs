/*
 * Copyright 2010-2014 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the appmesh-2018-10-01.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.AppMesh.Model;
using Amazon.AppMesh.Model.Internal.MarshallTransformations;
using Amazon.AppMesh.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.AppMesh
{
    /// <summary>
    /// Implementation for accessing AppMesh
    ///
    /// AWS App Mesh is a service mesh based on the Envoy proxy that makes it easy to monitor
    /// and         control containerized microservices. App Mesh standardizes how your microservices
    ///         communicate, giving you end-to-end visibility and helping to ensure high-availability
    /// for         your applications.
    /// 
    ///          
    /// <para>
    /// App Mesh gives you consistent visibility and network traffic controls for every  
    ///       microservice in an application. You can use App Mesh with Amazon ECS       
    ///  (using the Amazon EC2 launch type), Amazon EKS, and Kubernetes on AWS.
    /// </para>
    ///          <note>            
    /// <para>
    /// App Mesh supports containerized microservice applications that use service discovery
    ///            naming for their components. To use App Mesh, you must have a containerized
    /// application            running on Amazon EC2 instances, hosted in either Amazon ECS,
    /// Amazon EKS, or Kubernetes on AWS. For            more information about service discovery
    /// on Amazon ECS, see <a href="http://docs.aws.amazon.com/AmazonECS/latest/developerguideservice-discovery.html">Service
    /// Discovery</a> in the               <i>Amazon Elastic Container Service Developer Guide</i>.
    /// Kubernetes <code>kube-dns</code> is supported.            For more information, see
    /// <a href="https://kubernetes.io/docs/concepts/services-networking/dns-pod-service/">DNS
    ///               for Services and Pods</a> in the Kubernetes documentation.
    /// </para>
    ///          </note>
    /// </summary>
    public partial class AmazonAppMeshClient : AmazonServiceClient, IAmazonAppMesh
    {
        private static IServiceMetadata serviceMetadata = new AmazonAppMeshMetadata();
        #region Constructors

        /// <summary>
        /// Constructs AmazonAppMeshClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonAppMeshClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppMeshConfig()) { }

        /// <summary>
        /// Constructs AmazonAppMeshClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonAppMeshConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonAppMeshClient with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(AmazonAppMeshConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonAppMeshClient(AWSCredentials credentials)
            : this(credentials, new AmazonAppMeshConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonAppMeshConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Credentials and an
        /// AmazonAppMeshClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(AWSCredentials credentials, AmazonAppMeshConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppMeshConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonAppMeshConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppMeshClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonAppMeshConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppMeshConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonAppMeshConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonAppMeshClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonAppMeshClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonAppMeshClient Configuration Object</param>
        public AmazonAppMeshClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonAppMeshConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }    

        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
        #region  CreateMesh


        /// <summary>
        /// Creates a new service mesh. A service mesh is a logical boundary for network traffic
        ///         between the services that reside within it.
        /// 
        ///          
        /// <para>
        /// After you create your service mesh, you can create virtual nodes, virtual routers,
        /// and         routes to distribute traffic between the applications in your mesh.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateMesh service method.</param>
        /// 
        /// <returns>The response from the CreateMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        public virtual CreateMeshResponse CreateMesh(CreateMeshRequest request)
        {
            var marshaller = CreateMeshRequestMarshaller.Instance;
            var unmarshaller = CreateMeshResponseUnmarshaller.Instance;

            return Invoke<CreateMeshRequest,CreateMeshResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateMesh operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateMesh">REST API Reference for CreateMesh Operation</seealso>
        public virtual Task<CreateMeshResponse> CreateMeshAsync(CreateMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateMeshRequestMarshaller.Instance;
            var unmarshaller = CreateMeshResponseUnmarshaller.Instance;

            return InvokeAsync<CreateMeshRequest,CreateMeshResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute


        /// <summary>
        /// Creates a new route that is associated with a virtual router.
        /// 
        ///          
        /// <para>
        /// You can use the <code>prefix</code> parameter in your route specification for path-based
        ///         routing of requests. For example, if your virtual router service name is 
        ///           <code>my-service.local</code>, and you want the route to match requests
        /// to            <code>my-service.local/metrics</code>, then your prefix should be  
        ///       <code>/metrics</code>.
        /// </para>
        ///          
        /// <para>
        /// If your route matches a request, you can distribute traffic to one or more target
        ///         virtual nodes with relative weighting.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var marshaller = CreateRouteRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteRequest,CreateRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateRouteRequestMarshaller.Instance;
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteRequest,CreateRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVirtualNode


        /// <summary>
        /// Creates a new virtual node within a service mesh.
        /// 
        ///          
        /// <para>
        /// A virtual node acts as logical pointer to a particular task group, such as an Amazon
        /// ECS         service or a Kubernetes deployment. When you create a virtual node, you
        /// must specify the         DNS service discovery name for your task group.
        /// </para>
        ///          
        /// <para>
        /// Any inbound traffic that your virtual node expects should be specified as a      
        ///      <code>listener</code>. Any outbound traffic that your virtual node expects to
        /// reach         should be specified as a <code>backend</code>.
        /// </para>
        ///          
        /// <para>
        /// The response metadata for your new virtual node contains the <code>arn</code> that
        /// is         associated with the virtual node. Set this value (either the full ARN or
        /// the truncated         resource name, for example, <code>mesh/default/virtualNode/simpleapp</code>,
        /// as the            <code>APPMESH_VIRTUAL_NODE_NAME</code> environment variable for
        /// your task group's Envoy         proxy container in your task definition or pod spec.
        /// This is then mapped to the            <code>node.id</code> and <code>node.cluster</code>
        /// Envoy parameters.
        /// </para>
        ///          <note>            
        /// <para>
        /// If you require your Envoy stats or tracing to use a different name, you can override
        ///            the <code>node.cluster</code> value that is set by               <code>APPMESH_VIRTUAL_NODE_NAME</code>
        /// with the               <code>APPMESH_VIRTUAL_NODE_CLUSTER</code> environment variable.
        /// </para>
        ///          </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualNode service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        public virtual CreateVirtualNodeResponse CreateVirtualNode(CreateVirtualNodeRequest request)
        {
            var marshaller = CreateVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = CreateVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualNodeRequest,CreateVirtualNodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualNode">REST API Reference for CreateVirtualNode Operation</seealso>
        public virtual Task<CreateVirtualNodeResponse> CreateVirtualNodeAsync(CreateVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = CreateVirtualNodeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVirtualNodeRequest,CreateVirtualNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVirtualRouter


        /// <summary>
        /// Creates a new virtual router within a service mesh.
        /// 
        ///          
        /// <para>
        /// Virtual routers handle traffic for one or more service names within your mesh. After
        /// you         create your virtual router, create and associate routes for your virtual
        /// router that direct         incoming requests to different virtual nodes.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the CreateVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        public virtual CreateVirtualRouterResponse CreateVirtualRouter(CreateVirtualRouterRequest request)
        {
            var marshaller = CreateVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = CreateVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<CreateVirtualRouterRequest,CreateVirtualRouterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/CreateVirtualRouter">REST API Reference for CreateVirtualRouter Operation</seealso>
        public virtual Task<CreateVirtualRouterResponse> CreateVirtualRouterAsync(CreateVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = CreateVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = CreateVirtualRouterResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVirtualRouterRequest,CreateVirtualRouterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteMesh


        /// <summary>
        /// Deletes an existing service mesh.
        /// 
        ///          
        /// <para>
        /// You must delete all resources (routes, virtual routers, virtual nodes) in the service
        ///         mesh before you can delete the mesh itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteMesh service method.</param>
        /// 
        /// <returns>The response from the DeleteMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        public virtual DeleteMeshResponse DeleteMesh(DeleteMeshRequest request)
        {
            var marshaller = DeleteMeshRequestMarshaller.Instance;
            var unmarshaller = DeleteMeshResponseUnmarshaller.Instance;

            return Invoke<DeleteMeshRequest,DeleteMeshResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteMesh operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteMesh">REST API Reference for DeleteMesh Operation</seealso>
        public virtual Task<DeleteMeshResponse> DeleteMeshAsync(DeleteMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteMeshRequestMarshaller.Instance;
            var unmarshaller = DeleteMeshResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteMeshRequest,DeleteMeshResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute


        /// <summary>
        /// Deletes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var marshaller = DeleteRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteRouteRequestMarshaller.Instance;
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualNode


        /// <summary>
        /// Deletes an existing virtual node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualNode service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        public virtual DeleteVirtualNodeResponse DeleteVirtualNode(DeleteVirtualNodeRequest request)
        {
            var marshaller = DeleteVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = DeleteVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualNodeRequest,DeleteVirtualNodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualNode">REST API Reference for DeleteVirtualNode Operation</seealso>
        public virtual Task<DeleteVirtualNodeResponse> DeleteVirtualNodeAsync(DeleteVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = DeleteVirtualNodeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVirtualNodeRequest,DeleteVirtualNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualRouter


        /// <summary>
        /// Deletes an existing virtual router.
        /// 
        ///          
        /// <para>
        /// You must delete any routes associated with the virtual router before you can delete
        /// the         router itself.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the DeleteVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ResourceInUseException">
        /// You cannot delete the specified resource because it is in use or required by another
        /// resource.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        public virtual DeleteVirtualRouterResponse DeleteVirtualRouter(DeleteVirtualRouterRequest request)
        {
            var marshaller = DeleteVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = DeleteVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualRouterRequest,DeleteVirtualRouterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DeleteVirtualRouter">REST API Reference for DeleteVirtualRouter Operation</seealso>
        public virtual Task<DeleteVirtualRouterResponse> DeleteVirtualRouterAsync(DeleteVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DeleteVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = DeleteVirtualRouterResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVirtualRouterRequest,DeleteVirtualRouterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMesh


        /// <summary>
        /// Describes an existing cluster.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh service method.</param>
        /// 
        /// <returns>The response from the DescribeMesh service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        public virtual DescribeMeshResponse DescribeMesh(DescribeMeshRequest request)
        {
            var marshaller = DescribeMeshRequestMarshaller.Instance;
            var unmarshaller = DescribeMeshResponseUnmarshaller.Instance;

            return Invoke<DescribeMeshRequest,DescribeMeshResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMesh operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMesh operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeMesh">REST API Reference for DescribeMesh Operation</seealso>
        public virtual Task<DescribeMeshResponse> DescribeMeshAsync(DescribeMeshRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeMeshRequestMarshaller.Instance;
            var unmarshaller = DescribeMeshResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMeshRequest,DescribeMeshResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRoute


        /// <summary>
        /// Describes an existing route.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute service method.</param>
        /// 
        /// <returns>The response from the DescribeRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        public virtual DescribeRouteResponse DescribeRoute(DescribeRouteRequest request)
        {
            var marshaller = DescribeRouteRequestMarshaller.Instance;
            var unmarshaller = DescribeRouteResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteRequest,DescribeRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeRoute">REST API Reference for DescribeRoute Operation</seealso>
        public virtual Task<DescribeRouteResponse> DescribeRouteAsync(DescribeRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeRouteRequestMarshaller.Instance;
            var unmarshaller = DescribeRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRouteRequest,DescribeRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualNode


        /// <summary>
        /// Describes an existing virtual node.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        public virtual DescribeVirtualNodeResponse DescribeVirtualNode(DescribeVirtualNodeRequest request)
        {
            var marshaller = DescribeVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = DescribeVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualNodeRequest,DescribeVirtualNodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualNode">REST API Reference for DescribeVirtualNode Operation</seealso>
        public virtual Task<DescribeVirtualNodeResponse> DescribeVirtualNodeAsync(DescribeVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = DescribeVirtualNodeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVirtualNodeRequest,DescribeVirtualNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualRouter


        /// <summary>
        /// Describes an existing virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the DescribeVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        public virtual DescribeVirtualRouterResponse DescribeVirtualRouter(DescribeVirtualRouterRequest request)
        {
            var marshaller = DescribeVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = DescribeVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualRouterRequest,DescribeVirtualRouterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/DescribeVirtualRouter">REST API Reference for DescribeVirtualRouter Operation</seealso>
        public virtual Task<DescribeVirtualRouterResponse> DescribeVirtualRouterAsync(DescribeVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = DescribeVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = DescribeVirtualRouterResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVirtualRouterRequest,DescribeVirtualRouterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListMeshes


        /// <summary>
        /// Returns a list of existing service meshes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes service method.</param>
        /// 
        /// <returns>The response from the ListMeshes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        public virtual ListMeshesResponse ListMeshes(ListMeshesRequest request)
        {
            var marshaller = ListMeshesRequestMarshaller.Instance;
            var unmarshaller = ListMeshesResponseUnmarshaller.Instance;

            return Invoke<ListMeshesRequest,ListMeshesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListMeshes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListMeshes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListMeshes">REST API Reference for ListMeshes Operation</seealso>
        public virtual Task<ListMeshesResponse> ListMeshesAsync(ListMeshesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListMeshesRequestMarshaller.Instance;
            var unmarshaller = ListMeshesResponseUnmarshaller.Instance;

            return InvokeAsync<ListMeshesRequest,ListMeshesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListRoutes


        /// <summary>
        /// Returns a list of existing routes in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes service method.</param>
        /// 
        /// <returns>The response from the ListRoutes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        public virtual ListRoutesResponse ListRoutes(ListRoutesRequest request)
        {
            var marshaller = ListRoutesRequestMarshaller.Instance;
            var unmarshaller = ListRoutesResponseUnmarshaller.Instance;

            return Invoke<ListRoutesRequest,ListRoutesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListRoutes">REST API Reference for ListRoutes Operation</seealso>
        public virtual Task<ListRoutesResponse> ListRoutesAsync(ListRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListRoutesRequestMarshaller.Instance;
            var unmarshaller = ListRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<ListRoutesRequest,ListRoutesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVirtualNodes


        /// <summary>
        /// Returns a list of existing virtual nodes.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes service method.</param>
        /// 
        /// <returns>The response from the ListVirtualNodes service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        public virtual ListVirtualNodesResponse ListVirtualNodes(ListVirtualNodesRequest request)
        {
            var marshaller = ListVirtualNodesRequestMarshaller.Instance;
            var unmarshaller = ListVirtualNodesResponseUnmarshaller.Instance;

            return Invoke<ListVirtualNodesRequest,ListVirtualNodesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualNodes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualNodes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualNodes">REST API Reference for ListVirtualNodes Operation</seealso>
        public virtual Task<ListVirtualNodesResponse> ListVirtualNodesAsync(ListVirtualNodesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListVirtualNodesRequestMarshaller.Instance;
            var unmarshaller = ListVirtualNodesResponseUnmarshaller.Instance;

            return InvokeAsync<ListVirtualNodesRequest,ListVirtualNodesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ListVirtualRouters


        /// <summary>
        /// Returns a list of existing virtual routers in a service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters service method.</param>
        /// 
        /// <returns>The response from the ListVirtualRouters service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        public virtual ListVirtualRoutersResponse ListVirtualRouters(ListVirtualRoutersRequest request)
        {
            var marshaller = ListVirtualRoutersRequestMarshaller.Instance;
            var unmarshaller = ListVirtualRoutersResponseUnmarshaller.Instance;

            return Invoke<ListVirtualRoutersRequest,ListVirtualRoutersResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListVirtualRouters operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualRouters operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/ListVirtualRouters">REST API Reference for ListVirtualRouters Operation</seealso>
        public virtual Task<ListVirtualRoutersResponse> ListVirtualRoutersAsync(ListVirtualRoutersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = ListVirtualRoutersRequestMarshaller.Instance;
            var unmarshaller = ListVirtualRoutersResponseUnmarshaller.Instance;

            return InvokeAsync<ListVirtualRoutersRequest,ListVirtualRoutersResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateRoute


        /// <summary>
        /// Updates an existing route for a specified service mesh and virtual router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute service method.</param>
        /// 
        /// <returns>The response from the UpdateRoute service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual UpdateRouteResponse UpdateRoute(UpdateRouteRequest request)
        {
            var marshaller = UpdateRouteRequestMarshaller.Instance;
            var unmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return Invoke<UpdateRouteRequest,UpdateRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateRoute">REST API Reference for UpdateRoute Operation</seealso>
        public virtual Task<UpdateRouteResponse> UpdateRouteAsync(UpdateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateRouteRequestMarshaller.Instance;
            var unmarshaller = UpdateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateRouteRequest,UpdateRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateVirtualNode


        /// <summary>
        /// Updates an existing virtual node in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode service method.</param>
        /// 
        /// <returns>The response from the UpdateVirtualNode service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        public virtual UpdateVirtualNodeResponse UpdateVirtualNode(UpdateVirtualNodeRequest request)
        {
            var marshaller = UpdateVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = UpdateVirtualNodeResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualNodeRequest,UpdateVirtualNodeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualNode operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualNode operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualNode">REST API Reference for UpdateVirtualNode Operation</seealso>
        public virtual Task<UpdateVirtualNodeResponse> UpdateVirtualNodeAsync(UpdateVirtualNodeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateVirtualNodeRequestMarshaller.Instance;
            var unmarshaller = UpdateVirtualNodeResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVirtualNodeRequest,UpdateVirtualNodeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UpdateVirtualRouter


        /// <summary>
        /// Updates an existing virtual router in a specified service mesh.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter service method.</param>
        /// 
        /// <returns>The response from the UpdateVirtualRouter service method, as returned by AppMesh.</returns>
        /// <exception cref="Amazon.AppMesh.Model.BadRequestException">
        /// The request syntax was malformed. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ConflictException">
        /// The request contains a client token that was used for a previous update resource call
        ///         with different specifications. Try the request again with a new client token.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ForbiddenException">
        /// You do not have permissions to perform this action.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.InternalServerErrorException">
        /// The request processing has failed because of an unknown error, exception, or failure.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.LimitExceededException">
        /// You have exceeded a service limit for your account. For more information, see <a href="https://docs.aws.amazon.com/app-mesh/latest/userguide/service_limits.html">Service
        /// Limits</a> in the <i>AWS App Mesh User Guide</i>.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.NotFoundException">
        /// The specified resource does not exist. Check your request syntax and try again.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.ServiceUnavailableException">
        /// The request has failed due to a temporary failure of the service.
        /// </exception>
        /// <exception cref="Amazon.AppMesh.Model.TooManyRequestsException">
        /// The maximum request rate permitted by the App Mesh APIs has been exceeded for your
        ///         account. For best results, use an increasing or variable sleep interval between
        /// requests.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        public virtual UpdateVirtualRouterResponse UpdateVirtualRouter(UpdateVirtualRouterRequest request)
        {
            var marshaller = UpdateVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = UpdateVirtualRouterResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualRouterRequest,UpdateVirtualRouterResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVirtualRouter operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualRouter operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/appmesh-2018-10-01/UpdateVirtualRouter">REST API Reference for UpdateVirtualRouter Operation</seealso>
        public virtual Task<UpdateVirtualRouterResponse> UpdateVirtualRouterAsync(UpdateVirtualRouterRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = UpdateVirtualRouterRequestMarshaller.Instance;
            var unmarshaller = UpdateVirtualRouterResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVirtualRouterRequest,UpdateVirtualRouterResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}