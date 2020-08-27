// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RolePermissionsMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RolePermissionsMaintService : NamedDataObjectMaintBase
  {
    public RolePermissionsMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRolePermissionsMaintService), userProfile);
    }

    public ResultStatus AddPermissions(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_AddPermissions_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (AddPermissions), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).AddPermissions(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.AddPermissions, (RolePermissionsMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddPermissions), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddPermissions()
    {
      return this.AddPermissions((RolePermissionsMaint) null, (RolePermissionsMaint_AddPermissions_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus AddPermissions(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.AddPermissions(rolePermissionsMaint, (RolePermissionsMaint_AddPermissions_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus AddPermissions(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.AddPermissions(rolePermissionsMaint, (RolePermissionsMaint_AddPermissions_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).Delete(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus Delete(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.Delete(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus Delete(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.Delete(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeletePermissions(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (DeletePermissions), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).DeletePermissions(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.DeletePermissions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeletePermissions), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeletePermissions()
    {
      return this.DeletePermissions((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus DeletePermissions(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.DeletePermissions(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus DeletePermissions(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.DeletePermissions(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).Freeze(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus Freeze(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.Freeze(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus Freeze(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.Freeze(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).GetWIPMsgs(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.GetWIPMsgs(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.GetWIPMsgs(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).Load(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus Load(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.Load(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus Load(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.Load(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_LoadESigDetails_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).LoadESigDetails(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.LoadESigDetails, (RolePermissionsMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RolePermissionsMaint) null, (RolePermissionsMaint_LoadESigDetails_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.LoadESigDetails(rolePermissionsMaint, (RolePermissionsMaint_LoadESigDetails_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.LoadESigDetails(rolePermissionsMaint, (RolePermissionsMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).New(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus New(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.New(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus New(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.New(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).NewCopy(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus NewCopy(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.NewCopy(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus NewCopy(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.NewCopy(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).SaveAs(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus SaveAs(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.SaveAs(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus SaveAs(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.SaveAs(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Parameters parameters,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).UnFreeze(this._UserProfile, rolePermissionsMaint, parameters, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(rolePermissionsMaint, RolePermissionsMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) rolePermissionsMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RolePermissionsMaint) null, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus UnFreeze(RolePermissionsMaint rolePermissionsMaint)
    {
      return this.UnFreeze(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RolePermissionsMaint rolePermissionsMaint,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.UnFreeze(rolePermissionsMaint, (RolePermissionsMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_LoadESigDetails_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.New((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.Load((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject rolePermissionsMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RolePermissionsMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RolePermissionsMaint) rolePermissionsMaint, (RolePermissionsMaint_Parameters) parameters, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      try
      {
        RolePermissionsMaintMethod[] methods = new RolePermissionsMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRolePermissionsMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RolePermissionsMaint cdo,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      try
      {
        return ((IRolePermissionsMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RolePermissionsMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RolePermissionsMaint) cdo, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.GetEnvironment((RolePermissionsMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RolePermissionsMaint cdo,
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      result = (RolePermissionsMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRolePermissionsMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RolePermissionsMaintMethod(cdo, RolePermissionsMaintMethods.ExecuteTransaction, (RolePermissionsMaint_Parameters) null));
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
        RolePermissionsMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RolePermissionsMaint) cdo, (RolePermissionsMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RolePermissionsMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RolePermissionsMaint_Request) null, out RolePermissionsMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RolePermissionsMaint_Request request,
      out RolePermissionsMaint_Result result)
    {
      return this.ExecuteTransaction((RolePermissionsMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RolePermissionsMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RolePermissionsMaintMethod(cdo, RolePermissionsMaintMethods.AddDataTransaction, (RolePermissionsMaint_Parameters) null));
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
        return this.AddDataTransaction((RolePermissionsMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
