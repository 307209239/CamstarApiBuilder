// Decompiled with JetBrains decompiler
// Type: Camstar.WCF.Services.RoleMaintService
// Assembly: Camstar.WCFClient, Version=7.7.7004.31021, Culture=neutral, PublicKeyToken=null
// MVID: CA19AA1B-EA44-4AB0-A5CC-92D7FB49DA91
// Assembly location: E:\WCFServicesGenerator\Camstar.WCFClient.dll

using Camstar.WCF.ObjectStack;
using System;

namespace Camstar.WCF.Services
{
  public class RoleMaintService : NamedDataObjectMaintBase
  {
    public RoleMaintService(UserProfile userProfile)
    {
      this.Initialize(typeof (IRoleMaintService), userProfile);
    }

    public ResultStatus AddMembers(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (AddMembers), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).AddMembers(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.AddMembers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddMembers), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddMembers()
    {
      return this.AddMembers((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus AddMembers(RoleMaint roleMaint)
    {
      return this.AddMembers(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus AddMembers(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.AddMembers(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus AddPermissions(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (AddPermissions), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).AddPermissions(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.AddPermissions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (AddPermissions), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus AddPermissions()
    {
      return this.AddPermissions((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus AddPermissions(RoleMaint roleMaint)
    {
      return this.AddPermissions(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus AddPermissions(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.AddPermissions(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Delete(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (Delete), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).Delete(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.Delete, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Delete), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Delete()
    {
      return this.Delete((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus Delete(RoleMaint roleMaint)
    {
      return this.Delete(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus Delete(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.Delete(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeleteMembers(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (DeleteMembers), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).DeleteMembers(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.DeleteMembers, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeleteMembers), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeleteMembers()
    {
      return this.DeleteMembers((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus DeleteMembers(RoleMaint roleMaint)
    {
      return this.DeleteMembers(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus DeleteMembers(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.DeleteMembers(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus DeletePermissions(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (DeletePermissions), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).DeletePermissions(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.DeletePermissions, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (DeletePermissions), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus DeletePermissions()
    {
      return this.DeletePermissions((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus DeletePermissions(RoleMaint roleMaint)
    {
      return this.DeletePermissions(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus DeletePermissions(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.DeletePermissions(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Freeze(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (Freeze), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).Freeze(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.Freeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Freeze), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Freeze()
    {
      return this.Freeze((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus Freeze(RoleMaint roleMaint)
    {
      return this.Freeze(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus Freeze(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.Freeze(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus GetWIPMsgs(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (GetWIPMsgs), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).GetWIPMsgs(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.GetWIPMsgs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (GetWIPMsgs), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus GetWIPMsgs()
    {
      return this.GetWIPMsgs((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(RoleMaint roleMaint)
    {
      return this.GetWIPMsgs(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus GetWIPMsgs(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.GetWIPMsgs(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus Load(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (Load), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).Load(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.Load, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (Load), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus Load()
    {
      return this.Load((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus Load(RoleMaint roleMaint)
    {
      return this.Load(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus Load(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.Load(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus LoadESigDetails(
      RoleMaint roleMaint,
      RoleMaint_LoadESigDetails_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (LoadESigDetails), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).LoadESigDetails(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.LoadESigDetails, (RoleMaint_Parameters) parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (LoadESigDetails), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus LoadESigDetails()
    {
      return this.LoadESigDetails((RoleMaint) null, (RoleMaint_LoadESigDetails_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(RoleMaint roleMaint)
    {
      return this.LoadESigDetails(roleMaint, (RoleMaint_LoadESigDetails_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus LoadESigDetails(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.LoadESigDetails(roleMaint, (RoleMaint_LoadESigDetails_Parameters) null, request, out result);
    }

    public ResultStatus New(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (New), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).New(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.New, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (New), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus New()
    {
      return this.New((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus New(RoleMaint roleMaint)
    {
      return this.New(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus New(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.New(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus NewCopy(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (NewCopy), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).NewCopy(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.NewCopy, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (NewCopy), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus NewCopy()
    {
      return this.NewCopy((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus NewCopy(RoleMaint roleMaint)
    {
      return this.NewCopy(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus NewCopy(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.NewCopy(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus SaveAs(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (SaveAs), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).SaveAs(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.SaveAs, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (SaveAs), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus SaveAs()
    {
      return this.SaveAs((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus SaveAs(RoleMaint roleMaint)
    {
      return this.SaveAs(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus SaveAs(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.SaveAs(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    public ResultStatus UnFreeze(
      RoleMaint roleMaint,
      RoleMaint_Parameters parameters,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (UnFreeze), (DCObject) roleMaint, (Parameters) parameters, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).UnFreeze(this._UserProfile, roleMaint, parameters, request, out result) : this.AddMethod((Method) new RoleMaintMethod(roleMaint, RoleMaintMethods.UnFreeze, parameters));
      }
      catch (Exception ex)
      {
        res = this.OnThrowException(ex);
      }
      if (res.IsSuccess)
        this.OnAfterCall(nameof (UnFreeze), res, (DCObject) roleMaint, (Parameters) parameters, (Request) request, (Result) result);
      return res;
    }

    public ResultStatus UnFreeze()
    {
      return this.UnFreeze((RoleMaint) null, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus UnFreeze(RoleMaint roleMaint)
    {
      return this.UnFreeze(roleMaint, (RoleMaint_Parameters) null, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus UnFreeze(
      RoleMaint roleMaint,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.UnFreeze(roleMaint, (RoleMaint_Parameters) null, request, out result);
    }

    protected override ResultStatus OnDelete(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.Delete((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnFreeze(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.Freeze((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoadESigDetails(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.LoadESigDetails((RoleMaint) roleMaint, (RoleMaint_LoadESigDetails_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNew(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.New((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnNewCopy(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.NewCopy((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnSaveAs(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.SaveAs((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnUnFreeze(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.UnFreeze((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnLoad(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.Load((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    protected override ResultStatus OnGetWIPMsgs(
      DCObject roleMaint,
      Parameters parameters,
      Request request,
      out Result result)
    {
      result = (Result) null;
      try
      {
        RoleMaint_Result result1;
        ResultStatus wipMsgs = this.GetWIPMsgs((RoleMaint) roleMaint, (RoleMaint_Parameters) parameters, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return wipMsgs;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus CommitTransaction(
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      try
      {
        RoleMaintMethod[] methods = new RoleMaintMethod[this.GetMethodCount()];
        this.CopyMethods((Method[]) methods);
        return ((IRoleMaintService) this._Channel).CommitTransaction(this._UserProfile, methods, request, out result);
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
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.CommitTransaction((RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RoleMaint cdo,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      try
      {
        return ((IRoleMaintService) this._Channel).GetEnvironment(this._UserProfile, cdo, request, out result);
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
        RoleMaint_Result result1;
        ResultStatus environment = this.GetEnvironment((RoleMaint) cdo, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return environment;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus GetEnvironment(
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.GetEnvironment((RoleMaint) null, request, out result);
    }

    public ResultStatus ExecuteTransaction(
      RoleMaint cdo,
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      result = (RoleMaint_Result) null;
      this.OnBeforeCall(nameof (ExecuteTransaction), (DCObject) cdo, (Parameters) null, (Request) request);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? ((IRoleMaintService) this._Channel).ExecuteTransaction(this._UserProfile, cdo, request, out result) : this.AddMethod((Method) new RoleMaintMethod(cdo, RoleMaintMethods.ExecuteTransaction, (RoleMaint_Parameters) null));
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
        RoleMaint_Result result1;
        ResultStatus resultStatus = this.ExecuteTransaction((RoleMaint) cdo, (RoleMaint_Request) request, out result1);
        result = (Result) result1;
        return resultStatus;
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }

    public ResultStatus ExecuteTransaction(RoleMaint cdo)
    {
      return this.ExecuteTransaction(cdo, (RoleMaint_Request) null, out RoleMaint_Result _);
    }

    public ResultStatus ExecuteTransaction(
      RoleMaint_Request request,
      out RoleMaint_Result result)
    {
      return this.ExecuteTransaction((RoleMaint) null, request, out result);
    }

    public ResultStatus AddDataTransaction(RoleMaint cdo)
    {
      this.OnBeforeCall(nameof (AddDataTransaction), (DCObject) cdo, (Parameters) null, (Request) null);
      ResultStatus res;
      try
      {
        res = !this._IsTransactionOpened ? this.GetAddDataTransactionException() : this.AddMethod((Method) new RoleMaintMethod(cdo, RoleMaintMethods.AddDataTransaction, (RoleMaint_Parameters) null));
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
        return this.AddDataTransaction((RoleMaint) cdo);
      }
      catch (Exception ex)
      {
        return this.OnThrowException(ex);
      }
    }
  }
}
