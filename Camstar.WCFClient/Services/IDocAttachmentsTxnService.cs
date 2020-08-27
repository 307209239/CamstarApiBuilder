// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDocAttachmentsTxnService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDocAttachmentsTxnService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_LoadESigDetails_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Parameters parameters,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DocAttachmentsTxnMethod[] methods,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DocAttachmentsTxn docAttachmentsTxn,
      DocAttachmentsTxn_Request request,
      out DocAttachmentsTxn_Result result);
  }
}
