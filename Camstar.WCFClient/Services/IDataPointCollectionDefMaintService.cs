// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IDataPointCollectionDefMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IDataPointCollectionDefMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_LoadESigDetails_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Parameters parameters,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      DataPointCollectionDefMaintMethod[] methods,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      DataPointCollectionDefMaint dataPointCollectionDefMaint,
      DataPointCollectionDefMaint_Request request,
      out DataPointCollectionDefMaint_Result result);
  }
}
