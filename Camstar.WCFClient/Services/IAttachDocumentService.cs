// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IAttachDocumentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IAttachDocumentService
  {
    [OperationContract]
    ResultStatus AttachDocument_CreateDoc(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_AttachDocument_CreateDoc_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus AttachDocument_GetObjectInstance(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus AttachDocument_GetObjectType(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus AttachDocument_ValidateNotAlreadyAttached(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus AttachDocument_Validations(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_LoadESigDetails_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus MapLastActivityToContainer(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Parameters parameters,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      AttachDocumentMethod[] methods,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      AttachDocument attachDocument,
      AttachDocument_Request request,
      out AttachDocument_Result result);
  }
}
