// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISampleDataPointMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISampleDataPointMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_LoadESigDetails_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Parameters parameters,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SampleDataPointMaintMethod[] methods,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SampleDataPointMaint sampleDataPointMaint,
      SampleDataPointMaint_Request request,
      out SampleDataPointMaint_Result result);
  }
}
