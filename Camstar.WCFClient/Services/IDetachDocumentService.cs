// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDetachDocumentService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDetachDocumentService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_LoadESigDetails_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Parameters parameters,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DetachDocumentMethod[] methods,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DetachDocument detachDocument,
      DetachDocument_Request request,
      out DetachDocument_Result result);
  }
}
