// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDataCollectionDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDataCollectionDefMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_LoadESigDetails_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Parameters parameters,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DataCollectionDefMaintMethod[] methods,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DataCollectionDefMaint dataCollectionDefMaint,
      DataCollectionDefMaint_Request request,
      out DataCollectionDefMaint_Result result);
  }
}
