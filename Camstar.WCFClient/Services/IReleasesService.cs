// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.IReleasesService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System.ServiceModel;

namespace Camstar.WCF.Services
{
  [ServiceContract]
  public interface IReleasesService
  {
    [OperationContract]
    ResultStatus CreateParametricData(
      UserProfile userProfile,
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus GetActions(
      UserProfile userProfile,
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus GetDataPoints(
      UserProfile userProfile,
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus GetWIPMsgs(
      UserProfile userProfile,
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus Load(
      UserProfile userProfile,
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus LoadESigDetails(
      UserProfile userProfile,
      Releases releases,
      Releases_LoadESigDetails_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus ProcessComputation(
      UserProfile userProfile,
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus ResolveParametricData(
      UserProfile userProfile,
      Releases releases,
      Releases_Parameters parameters,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus CommitTransaction(
      UserProfile userProfile,
      ReleasesMethod[] methods,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus ExecuteTransaction(
      UserProfile userProfile,
      Releases releases,
      Releases_Request request,
      out Releases_Result result);

    [OperationContract]
    ResultStatus GetEnvironment(
      UserProfile userProfile,
      Releases releases,
      Releases_Request request,
      out Releases_Result result);
  }
}
