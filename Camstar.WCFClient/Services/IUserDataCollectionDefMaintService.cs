// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IUserDataCollectionDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IUserDataCollectionDefMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_LoadESigDetails_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Parameters parameters,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      UserDataCollectionDefMaintMethod[] methods,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      UserDataCollectionDefMaint userDataCollectionDefMaint,
      UserDataCollectionDefMaint_Request request,
      out UserDataCollectionDefMaint_Result result);
  }
}
