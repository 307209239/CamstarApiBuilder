// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IESigMeaningMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IESigMeaningMaintService
  {
    [OperationContract]
    ResultStatus Delete(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus Freeze(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_LoadESigDetails_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus New(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus NewCopy(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus SaveAs(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus UnFreeze(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Parameters parameters,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ESigMeaningMaintMethod[] methods,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      ESigMeaningMaint eSigMeaningMaint,
      ESigMeaningMaint_Request request,
      out ESigMeaningMaint_Result result);
  }
}
