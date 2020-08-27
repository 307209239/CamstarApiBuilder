// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.ISampleTestMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface ISampleTestMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus DeleteAllRevisions(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_LoadESigDetails_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus NewRev(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus NewRevCopy(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus SaveAsRev(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Parameters parameters,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      SampleTestMaintMethod[] methods,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      SampleTestMaint sampleTestMaint,
      SampleTestMaint_Request request,
      out SampleTestMaint_Result result);
  }
}
