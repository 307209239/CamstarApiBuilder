// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.StartChangePkgService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class StartChangePkgService : BPStartTxnBase
  {
    public StartChangePkgService(UserProfile userProfile)
    {
      this.Initialize(typeof (IStartChangePkgService), userProfile);
    }

    public ResultStatus CreateParametricData(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (CreateParametricData), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).CreateParametricData(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.CreateParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (CreateParametricData), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus CreateParametricData()
    {
      return this.CreateParametricData((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(StartChangePkg startChangePkg)
    {
      return this.CreateParametricData(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus CreateParametricData(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.CreateParametricData(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetActions(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetActions), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).GetActions(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.GetActions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetActions), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetActions()
    {
      return this.GetActions((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus GetActions(StartChangePkg startChangePkg)
    {
      return this.GetActions(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus GetActions(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.GetActions(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetDataPoints(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetDataPoints), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).GetDataPoints(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.GetDataPoints, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetDataPoints), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetDataPoints()
    {
      return this.GetDataPoints((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(StartChangePkg startChangePkg)
    {
      return this.GetDataPoints(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus GetDataPoints(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.GetDataPoints(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).GetWIPMsgs(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(StartChangePkg startChangePkg)
    {
      return this.GetWIPMsgs(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus GetWIPMsgs(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.GetWIPMsgs(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).Load(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus Load(StartChangePkg startChangePkg)
    {
      return this.Load(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus Load(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.Load(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      StartChangePkg startChangePkg,
      StartChangePkg_LoadESigDetails_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).LoadESigDetails(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.LoadESigDetails, (StartChangePkg_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((StartChangePkg) null, (StartChangePkg_LoadESigDetails_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(StartChangePkg startChangePkg)
    {
      return this.LoadESigDetails(startChangePkg, (StartChangePkg_LoadESigDetails_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus LoadESigDetails(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.LoadESigDetails(startChangePkg, (StartChangePkg_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus LoadTemplate(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (LoadTemplate), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).LoadTemplate(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.LoadTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadTemplate), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadTemplate()
    {
      return this.LoadTemplate((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus LoadTemplate(StartChangePkg startChangePkg)
    {
      return this.LoadTemplate(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus LoadTemplate(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.LoadTemplate(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ProcessComputation(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (ProcessComputation), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).ProcessComputation(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.ProcessComputation, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ProcessComputation), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ProcessComputation()
    {
      return this.ProcessComputation((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(StartChangePkg startChangePkg)
    {
      return this.ProcessComputation(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus ProcessComputation(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.ProcessComputation(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ResolveParametricData(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (ResolveParametricData), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).ResolveParametricData(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.ResolveParametricData, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ResolveParametricData), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ResolveParametricData()
    {
      return this.ResolveParametricData((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(StartChangePkg startChangePkg)
    {
      return this.ResolveParametricData(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus ResolveParametricData(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.ResolveParametricData(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus SaveApprovalTemplate(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (SaveApprovalTemplate), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).SaveApprovalTemplate(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.SaveApprovalTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveApprovalTemplate), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveApprovalTemplate()
    {
      return this.SaveApprovalTemplate((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus SaveApprovalTemplate(StartChangePkg startChangePkg)
    {
      return this.SaveApprovalTemplate(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus SaveApprovalTemplate(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.SaveApprovalTemplate(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus SaveCollaboratorTemplate(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (SaveCollaboratorTemplate), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).SaveCollaboratorTemplate(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.SaveCollaboratorTemplate, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveCollaboratorTemplate), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveCollaboratorTemplate()
    {
      return this.SaveCollaboratorTemplate((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus SaveCollaboratorTemplate(StartChangePkg startChangePkg)
    {
      return this.SaveCollaboratorTemplate(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus SaveCollaboratorTemplate(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.SaveCollaboratorTemplate(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus Validate_ServerCatalogSetUp(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (Validate_ServerCatalogSetUp), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).Validate_ServerCatalogSetUp(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.Validate_ServerCatalogSetUp, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Validate_ServerCatalogSetUp), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Validate_ServerCatalogSetUp()
    {
      return this.Validate_ServerCatalogSetUp((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus Validate_ServerCatalogSetUp(StartChangePkg startChangePkg)
    {
      return this.Validate_ServerCatalogSetUp(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus Validate_ServerCatalogSetUp(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.Validate_ServerCatalogSetUp(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    public ResultStatus ValidateChangePackage(
      StartChangePkg startChangePkg,
      StartChangePkg_Parameters parameters,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (ValidateChangePackage), (DCObject) startChangePkg, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).ValidateChangePackage(this._UserProfile, startChangePkg, parameters, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(startChangePkg, StartChangePkgMethods.ValidateChangePackage, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ValidateChangePackage), res, (DCObject) startChangePkg, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus ValidateChangePackage()
    {
      return this.ValidateChangePackage((StartChangePkg) null, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus ValidateChangePackage(StartChangePkg startChangePkg)
    {
      return this.ValidateChangePackage(startChangePkg, (StartChangePkg_Parameters) null, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus ValidateChangePackage(
      StartChangePkg startChangePkg,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.ValidateChangePackage(startChangePkg, (StartChangePkg_Parameters) null, request, out result);
    }

    protected override ResultStatus OnCreateParametricData(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus parametricData = this.CreateParametricData((StartChangePkg) startChangePkg, (StartChangePkg_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return parametricData;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetActions(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus actions = this.GetActions((StartChangePkg) startChangePkg, (StartChangePkg_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return actions;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetDataPoints(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus dataPoints = this.GetDataPoints((StartChangePkg) startChangePkg, (StartChangePkg_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return dataPoints;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((StartChangePkg) startChangePkg, (StartChangePkg_LoadESigDetails_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnProcessComputation(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus resultStatus = this.ProcessComputation((StartChangePkg) startChangePkg, (StartChangePkg_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnResolveParametricData(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus resultStatus = this.ResolveParametricData((StartChangePkg) startChangePkg, (StartChangePkg_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus resultStatus = this.Load((StartChangePkg) startChangePkg, (StartChangePkg_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject startChangePkg,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((StartChangePkg) startChangePkg, (StartChangePkg_Parameters) parameters, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      try
      {
        StartChangePkgMethod[] methods = new StartChangePkgMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IStartChangePkgService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnCommitTransaction(
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      StartChangePkg cdo,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      try
      {
        return ((IStartChangePkgService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetEnvironment(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus environment = this.GetEnvironment((StartChangePkg) cdo, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.GetEnvironment((StartChangePkg) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      StartChangePkg cdo,
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      result = (StartChangePkg_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IStartChangePkgService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new StartChangePkgMethod(cdo, StartChangePkgMethods.ExecuteTransaction, (StartChangePkg_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (ExecuteTransaction), res, (DCObject) cdo, (Parameters) null, (Request) request, (Result) result);
      return res;
    }

    protected override ResultStatus OnExecuteTransaction(
      DCObject cdo,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        StartChangePkg_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((StartChangePkg) cdo, (StartChangePkg_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(StartChangePkg cdo)
    {
      return this.ExecuteTransaction(cdo, (StartChangePkg_Request) null, out StartChangePkg_Result _);
    }

    public ResultStatus ExecuteTransaction(
      StartChangePkg_Request request,
      out StartChangePkg_Result result)
    {
      return this.ExecuteTransaction((StartChangePkg) null, request, out result);
    }

    public ResultStatus AddDataTransaction(StartChangePkg cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new StartChangePkgMethod(cdo, StartChangePkgMethods.AddDataTransaction, (StartChangePkg_Parameters) null));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
      {
        Result result;
        this.OnAfterCall(nameof (AddDataTransaction), res, (DCObject) cdo, (Parameters) null, (Request) null, result);
      }
      return res;
    }

    protected override ResultStatus OnAddDataTransaction(DCObject cdo)
    {
      try
      {
        return this.AddDataTransaction((StartChangePkg) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
