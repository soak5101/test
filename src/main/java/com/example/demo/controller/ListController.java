package com.example.demo.controller;

import com.example.demo.model.SearchResult;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RequestParam;

import java.util.ArrayList;
import java.util.List;

@Controller
public class ListController {

    @GetMapping("/list")
    public String getListView(Model model) {
        model.addAttribute("results", new ArrayList<SearchResult>());
        model.addAttribute("pageNumber", 1);
        model.addAttribute("totalPages", 1);
        return "list";
    }

    @PostMapping("/search")
    public String search(@RequestParam("search") String search, Model model) {
        List<SearchResult> results = new ArrayList<>();
        for (int i = 1; i <= 10; i++) {
            SearchResult result = new SearchResult();
            result.setId(i);
            result.setName("Name " + i);
            result.setDescription("Description " + i);
            results.add(result);
        }
        model.addAttribute("results", results);
        model.addAttribute("pageNumber", 1);
        model.addAttribute("totalPages", 1);
        return "list";
    }
}
