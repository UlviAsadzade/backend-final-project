using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using QuarterTemplate.Helpers;
using QuarterTemplate.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QuarterTemplate.Areas.Manage.Controllers
{
    [Area("manage")]
    [Authorize(Roles = "Admin,SuperAdmin")]

    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

        public IActionResult Index()
        {
            Setting settings = _context.Settings.FirstOrDefault();
            return View(settings);
        }


        public IActionResult Edit()
        {
            Setting setting = _context.Settings.FirstOrDefault();
            return View(setting);
        }

        [HttpPost]
        public IActionResult Edit(Setting setting)
        {

            Setting existSetting = _context.Settings.FirstOrDefault();
            if (existSetting == null) return RedirectToAction("index", "error", new {area="" });

            if (!ModelState.IsValid) return View(existSetting);


            if (setting.HeaderLogoFile != null)
            {
                if (setting.HeaderLogoFile.ContentType != "image/png" && setting.HeaderLogoFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("HeaderLogoFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.HeaderLogoFile.Length > 2097152)
                {
                    ModelState.AddModelError("HeaderLogoFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.HeaderLogo != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.HeaderLogo);
                }

                string headerFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.HeaderLogoFile);

                existSetting.HeaderLogo = headerFileName;

            }
            else
            {
                if (setting.HeaderLogo == null)
                {
                    if (existSetting.HeaderLogo != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.HeaderLogo);
                        existSetting.HeaderLogo = null;
                    }
                }
            }



            if (setting.FooterLogoFile != null)
            {
                if (setting.FooterLogoFile.ContentType != "image/png" && setting.FooterLogoFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("FooterLogoFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.FooterLogoFile.Length > 2097152)
                {
                    ModelState.AddModelError("FooterLogoFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.FooterLogo != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.FooterLogo);
                }

                string footerFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.FooterLogoFile);

                existSetting.FooterLogo = footerFileName;

            }
            else
            {
                if (setting.FooterLogo == null)
                {
                    if (existSetting.FooterLogo != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.FooterLogo);
                        existSetting.FooterLogo = null;
                    }
                }
            }


            if (setting.PhoneImageFile != null)
            {
                if (setting.PhoneImageFile.ContentType != "image/png" && setting.PhoneImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("PhoneImageFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.PhoneImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("PhoneImageFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.PhoneImage != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.PhoneImage);
                }

                string phoneFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.PhoneImageFile);

                existSetting.PhoneImage = phoneFileName;

            }
            else
            {
                if (setting.PhoneImage == null)
                {
                    if (existSetting.PhoneImage != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.PhoneImage);
                        existSetting.PhoneImage = null;
                    }
                }
            }


            if (setting.EmailImageFile != null)
            {
                if (setting.EmailImageFile.ContentType != "image/png" && setting.EmailImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("EmailImageFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.EmailImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("EmailImageFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.EmailImage != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.EmailImage);
                }

                string emailFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.EmailImageFile);

                existSetting.EmailImage = emailFileName;

            }
            else
            {
                if (setting.EmailImage == null)
                {
                    if (existSetting.EmailImage != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.EmailImage);
                        existSetting.EmailImage = null;
                    }
                }
            }

            if (setting.AboutImageBigFile != null)
            {
                if (setting.AboutImageBigFile.ContentType != "image/png" && setting.AboutImageBigFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("AboutImageBigFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.AboutImageBigFile.Length > 2097152)
                {
                    ModelState.AddModelError("AboutImageBigFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.AboutImage1 != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.AboutImage1);
                }

                string aboutBigFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.AboutImageBigFile);

                existSetting.AboutImage1 = aboutBigFileName;

            }
            else
            {
                if (setting.AboutImage1 == null)
                {
                    if (existSetting.AboutImage1 != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.AboutImage1);
                        existSetting.AboutImage1 = null;
                    }
                }
            }

            if (setting.AboutImageLittleFile != null)
            {
                if (setting.AboutImageLittleFile.ContentType != "image/png" && setting.AboutImageLittleFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("AboutImageLittleFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.AboutImageLittleFile.Length > 2097152)
                {
                    ModelState.AddModelError("AboutImageLittleFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.AboutImage2 != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.AboutImage2);
                }

                string aboutLittleFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.AboutImageLittleFile);

                existSetting.AboutImage2 = aboutLittleFileName;

            }
            else
            {
                if (setting.AboutImage2 == null)
                {
                    if (existSetting.AboutImage2 != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.AboutImage2);
                        existSetting.AboutImage2 = null;
                    }
                }
            }


            if (setting.AdressImageFile != null)
            {
                if (setting.AdressImageFile.ContentType != "image/png" && setting.AdressImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("AdressImageFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.AdressImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("AdressImageFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.AdressImage != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.AdressImage);
                }

                string adresFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.AdressImageFile);

                existSetting.AdressImage = adresFileName;

            }
            else
            {
                if (setting.AdressImage == null)
                {
                    if (existSetting.AdressImage != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.AdressImage);
                        existSetting.AdressImage = null;
                    }
                }
            }



            if (setting.VideoImageFile != null)
            {
                if (setting.VideoImageFile.ContentType != "image/png" && setting.VideoImageFile.ContentType != "image/jpeg")
                {
                    ModelState.AddModelError("VideoImageFile", "File type can be only jpeg,jpg or png!");
                    return View();
                }

                if (setting.VideoImageFile.Length > 2097152)
                {
                    ModelState.AddModelError("VideoImageFile", "File size can not be more than 2MB!");
                    return View();
                }

                if (existSetting.VideoImage != null)
                {
                    FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.VideoImage);
                }

                string videoFileName = FileManager.Save(_env.WebRootPath, "uploads/setting", setting.VideoImageFile);

                existSetting.VideoImage = videoFileName;

            }
            else
            {
                if (setting.VideoImage == null)
                {
                    if (existSetting.VideoImage != null)
                    {
                        FileManager.Delete(_env.WebRootPath, "uploads/setting", existSetting.VideoImage);
                        existSetting.VideoImage = null;
                    }
                }
            }


            existSetting.Phone1 = setting.Phone1;
            existSetting.Phone2 = setting.Phone2;
            existSetting.Email1 = setting.Email1;
            existSetting.Email2 = setting.Email2;
            existSetting.Address = setting.Address;
            existSetting.LocationIcon = setting.LocationIcon;
            existSetting.PhoneIcon = setting.PhoneIcon;
            existSetting.EmailIcon = setting.EmailIcon;
            existSetting.FacebookIcon = setting.FacebookIcon;
            existSetting.FacebookUrl = setting.FacebookUrl;
            existSetting.TwitterIcon = setting.TwitterIcon;
            existSetting.TwitterUrl = setting.TwitterUrl;
            existSetting.LinkedinIcon = setting.LinkedinIcon;
            existSetting.LinkedinUrl = setting.LinkedinUrl;
            existSetting.YoutubeIcon = setting.YoutubeIcon;
            existSetting.YoutubeUrl = setting.YoutubeUrl;
            existSetting.AboutTitle = setting.AboutTitle;
            existSetting.AboutDesc = setting.AboutDesc;
            existSetting.AboutText = setting.AboutText;
            existSetting.AboutRedirrectUrl = setting.AboutRedirrectUrl;
            existSetting.AboutUrlText = setting.AboutUrlText;

            _context.SaveChanges();
            return RedirectToAction("index");
        }


      
    }
}
